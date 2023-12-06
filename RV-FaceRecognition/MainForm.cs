using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Face;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using RV_FaceRecognition.Components.Methods;

namespace RV_FaceRecognition
{
    public partial class MainForm : Form
    {
        #region -- Values --
        private int usersId;
        private string login;
        private string password;
        private int userRole;

        private TokenManager tokenManager;
        private TokenDatabase tokenDatabase;

        /* Detection values */
        private VideoCapture videoCapture;
        private Image<Bgr, Byte> currentFrame;
        private Mat frame;

        private bool facesDetectionEnable;
        private bool enableSaveImage;
        private bool isTrained;
        
        private List<int> personsLabes;
        private List<string> personsNames;
        private List<Image<Gray, Byte>> trainedFaces;

        private CascadeClassifier faceCascadeClassifier;
        private EigenFaceRecognizer recognizer;

        /* Get/Set */
        public int UserId
        {
            get => usersId;
        }
        public string Login
        {
            get => login;
        }
        public string Password
        {
            get => password;
        }
        public int UserRole
        {
            get => userRole;
        }
        #endregion

        public MainForm()
        {
            InitializeComponent();

            try
            {
                // Init variables
                tokenManager = new TokenManager(Properties.Settings.Default.rv_facerecognitionConnectionString);
                tokenDatabase = new TokenDatabase(Properties.Settings.Default.rv_facerecognitionConnectionString);

                videoCapture = null;
                currentFrame = null;
                frame = new Mat();

                facesDetectionEnable = false;
                enableSaveImage = false;
                isTrained = false;

                faceCascadeClassifier = new CascadeClassifier(@".\haarcascade_frontalface_alt.xml");

                personsLabes = new List<int>();
                personsNames = new List<string>();
                trainedFaces = new List<Image<Gray, Byte>>();

                customButtonAddImage.Enabled = false;
                customButtonInfoWindow.Enabled = false;
                customButtonRecords.Enabled = false;
            }
            catch (Exception ex)
            {
                //Write ex.Message to a file
                using (StreamWriter outfile = new StreamWriter(@".\errorLog.txt"))
                {
                    outfile.Write(ex.Message.ToString());
                }
            }
        }

        #region -- Face Detection --
        // Запускаем камеру для распознавания
        private void customButtonCamera_Click(object sender, EventArgs e)
        {
            if (videoCapture != null) return;

            videoCapture = new VideoCapture();
            videoCapture.ImageGrabbed += ProcessFrame;
            videoCapture.Start();
        }

        private void ProcessFrame(object sender, EventArgs e)
        {
            /* Video capture */
            videoCapture.Retrieve(frame, 0);
            currentFrame = frame.ToImage<Bgr, Byte>().Resize(roundedPictureBox1.Width, roundedPictureBox1.Height, Inter.Cubic);

            /* Detect faces */
            if (facesDetectionEnable)
            {
                /* - Convert from Bgr to Gray Image - */
                Mat grayImage = new Mat();
                CvInvoke.CvtColor(currentFrame, grayImage, ColorConversion.Bgr2Gray);

                /* - Equalize the image to get better result - */
                CvInvoke.EqualizeHist(grayImage, grayImage);

                Rectangle[] faces = faceCascadeClassifier.DetectMultiScale(grayImage, 1.1, 3, Size.Empty, Size.Empty);
                
                /* - If faces detected - */
                if (faces.Length > 0)
                {
                    foreach (var face in faces)
                    {
                        /* -- Draw square around faces -- */
                        CvInvoke.Rectangle(currentFrame, face, new Bgr(Color.Red).MCvScalar, 2);

                        /* Add Persone */
                        Image<Bgr, Byte> resultImage = currentFrame.Convert<Bgr, Byte>();
                        resultImage.ROI = face;

                        if (enableSaveImage)
                        {
                            /* - We will create a directory if does not exists - */
                            string path = Directory.GetCurrentDirectory() + @"\SavedImages";
                            if (!Directory.Exists(path))
                                Directory.CreateDirectory(path);

                            path = path + @"\" + this.login + "_" + DateTime.Now.ToString("dd-mm-yyyy-hh-mm-ss") + ".jpg";
                            resultImage.Resize(200, 200, Inter.Cubic).Save(path);

                            
                            var answer = MessageBox.Show("Вы хотите загрузить данное изображение в базу данных?", "Загрузка в БД", MessageBoxButtons.YesNo);
                            if (answer == DialogResult.Yes)
                            {
                                FormImage formImage = new FormImage(path, this.usersId);
                                formImage.ShowDialog();
                            } 
                        }

                        enableSaveImage = false;
 
                        /* Recognize the face */
                        if (isTrained)
                        {
                            Image<Gray, Byte> grayFaceResult = resultImage.Convert<Gray, Byte>().Resize(200, 200, Inter.Cubic);
                            CvInvoke.EqualizeHist(grayFaceResult, grayFaceResult);
                            var result = recognizer.Predict(grayFaceResult);

                            /* - Here results found known faces - */
                            if (result.Label != -1 && result.Distance < 4500)
                            {
                                CvInvoke.PutText(currentFrame, personsNames[result.Label], new Point(face.X - 2, face.Y - 2),
                                    FontFace.HersheyComplex, 1.0, new Bgr(Color.Orange).MCvScalar);
                                CvInvoke.Rectangle(currentFrame, face, new Bgr(Color.Green).MCvScalar, 2);
                            }
                            /* - Here results did not found any know faces - */
                            else
                            {
                                CvInvoke.PutText(currentFrame, "Unknown", new Point(face.X - 2, face.Y - 2),
                                    FontFace.HersheyComplex, 1.0, new Bgr(Color.Orange).MCvScalar);

                                CvInvoke.Rectangle(currentFrame, face, new Bgr(Color.Red).MCvScalar, 2);
                            }
                        }
                    }
                }
            }

            // Render the video capture into the picture box
            try
            {
                roundedPictureBox1.Image = currentFrame.ToBitmap();
            }
            catch (Exception ex)
            {
                return;
            }
        }

        private void customButtonDetect_Click(object sender, EventArgs e)
        {
            facesDetectionEnable = !facesDetectionEnable;
        }

        private void customButtonAddImage_Click(object sender, EventArgs e)
        {
            enableSaveImage = !enableSaveImage;
        }

        private void customButtonTrain_Click(object sender, EventArgs e)
        {
            isTrained = false;
            TrainImagesFromDir();
        }


        /* Train images. We will use the saved images from the data base */
        private void TrainImagesFromDir()
        {
            int imagesCount = 0;
            double threshold = 10000;

            trainedFaces.Clear();
            personsLabes.Clear();
            personsNames.Clear();

            List<string> imageFiles = new List<string>();

            using (var connection = new SqlConnection(Properties.Settings.Default.rv_facerecognitionConnectionString))
            {
                connection.Open();

                string query = "SELECT IMAGE_FILE, IMAGE_NAME FROM IMAGES";
                SqlCommand command = new SqlCommand(query, connection);

                SqlDataReader reader = command.ExecuteReader();

                if (!reader.HasRows) return;

                while (reader.Read())
                {
                    // Save the image file to a temporary path
                    byte[] imageBytes = (byte[])reader["IMAGE_FILE"];
                    string name = reader["IMAGE_NAME"].ToString();
                    personsNames.Add(name);

                    string tempImagePath = Path.GetTempFileName();
                    File.WriteAllBytes(tempImagePath, imageBytes);
                    imageFiles.Add(tempImagePath);
                }

                reader.Close();
            }

            try
            {
                foreach (var file in imageFiles)
                {
                    // Read the image file using Emgu.CV
                    Image<Bgr, Byte> trainedImage = new Image<Bgr, Byte>(file);

                    // Convert the image to Gray scale
                    Image<Gray, Byte> grayImage = trainedImage.Convert<Gray, Byte>();

                    CvInvoke.EqualizeHist(grayImage, grayImage);

                    trainedFaces.Add(grayImage);
                    personsLabes.Add(imagesCount);
                    
                    imagesCount++;
                }

                if (trainedFaces.Count() > 0)
                {
                    // Main function. We will train recognizer on the images and set the border
                    recognizer = new EigenFaceRecognizer(imagesCount, threshold);
                    
                    VectorOfInt vectorOfLabels = new VectorOfInt();
                    VectorOfMat vectorOfFaces = new VectorOfMat();

                    vectorOfLabels.Push(personsLabes.ToArray());
                    vectorOfFaces.Push(trainedFaces.ToArray());

                    recognizer.Train(vectorOfFaces, vectorOfLabels);

                    isTrained = true;
                }

                return;
            }
            catch (Exception ex)
            {
                isTrained = false;
                MessageBox.Show("Error in Train Images: " + ex.Message);
                return;
            }
        }
        #endregion

        // Открываем модалку авторизации и в случае успеха заполяем поля и разрешаем доступы в зависимости от роли, так же генерируем новый токен
        private void CustomButtonAuth_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.ShowDialog();

            if (formLogin.DialogResult == DialogResult.OK)
            {
                if (tokenManager.GetTokenFromRegistry() != null)
                {
                    tokenDatabase.RemoveTokenFromDatabase(tokenManager.GetTokenFromRegistry());
                    tokenManager.RemoveTokenFromRegistry();
                }

                labelLogin.Text = formLogin.login;
                labelRole.Text = formLogin.role;

                this.usersId = formLogin.UsersId;
                this.login = formLogin.login;
                this.password = formLogin.password;
                this.userRole = formLogin.roleId;

                customButtonInfoWindow.Enabled = true;

                if (this.userRole == 2)
                {
                    customButtonAddImage.Enabled = true;
                    customButtonRecords.Enabled = true;
                }
                else
                {
                    customButtonAddImage.Enabled = false;
                    customButtonRecords.Enabled = false;
                }

                string token = TokenGenerator.GenerateRandomToken(64);
                token = TokenGenerator.ComputeSHA256Hash(token);

                tokenManager.SaveTokenToRegistry(token, this.usersId);
            }
        }

        // Открываем окно с изобажениями из БД
        private void CustomButtonInfoWindow_Click(object sender, EventArgs e)
        {
            FormInfo formInfo = new FormInfo(this.usersId, this.userRole);
            formInfo.ShowDialog();
        }

        // Открываем окно с записями логов приложения из БД
        private void customButtonRecords_Click(object sender, EventArgs e)
        {
            FormRecords formRecords = new FormRecords(this.usersId);
            formRecords.ShowDialog();
        }

        // Проверяем наличия токен и в случае успеха авторизируем пользователя
        private void MainForm_Load(object sender, EventArgs e)
        {
            // Получаем токен из реестра
            string token = tokenManager.GetTokenFromRegistry();

            if (token == null) return;

            // Проверяем наличие и валидность токена
            if (!string.IsNullOrEmpty(token) && tokenManager.IsTokenValid(token))
            {
                // Токен присутствует и валиден, выполняем авторизацию
                this.usersId = tokenManager.UsersId;

                using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.rv_facerecognitionConnectionString))
                {
                    // Открываем соединение с базой данных
                    connection.Open();

                    // Создаем SQL-запрос для получения данных
                    string query = "SELECT USERS.USER_LOGIN, USERS.USER_PASSWORD, USERS.ROLE_ID, ROLES.ROLE_NAME " +
                           "FROM USERS " +
                           "JOIN ROLES ON USERS.ROLE_ID = ROLES.ROLE_ID " +
                           "WHERE USERS.USERS_ID = @USERS_ID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Добавляем в параметры введенный логин
                        command.Parameters.AddWithValue("@USERS_ID", this.usersId);

                        SqlDataReader reader = command.ExecuteReader();

                        if (!reader.HasRows) return;

                        reader.Read();

                        this.login = reader.GetString(0);
                        this.password = reader.GetString(1);
                        this.userRole = reader.GetInt16(2);
                            
                        labelLogin.Text = this.login;
                        labelRole.Text = reader.GetString(3);

                        customButtonInfoWindow.Enabled = true;

                        if (this.userRole == 2)
                        {
                            customButtonAddImage.Enabled = true;
                            customButtonRecords.Enabled = true;
                        }
                        else
                        {
                            customButtonAddImage.Enabled = false;
                            customButtonRecords.Enabled = false;
                        }

                        reader.Close();
                    }
                }

            }
        }
    }
}
