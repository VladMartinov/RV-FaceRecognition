using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace RV_FaceRecognition
{
    public partial class FormImage : Form
    {
        #region -- Values --
        private string login;

        private byte[] imageInByte;

        private int ImageId = -1;
        #endregion


        public FormImage(string login)
        {
            InitializeComponent();
            this.login = login;
        }

        public FormImage(string login, int ID)
        {
            InitializeComponent();

            ImageId = ID;
            this.login = login;

            using (var connection = new SqlConnection(Properties.Settings.Default.rv_facerecognitionConnectionString))
            {
                connection.Open();

                string query = "SELECT IMAGE_FILE, IMAGE_NAME, LEARNING_STATUS FROM IMAGES WHERE IMAGE_ID = @IMAGE_ID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IMAGE_ID", ImageId);

                SqlDataReader reader = command.ExecuteReader();

                if (!reader.HasRows) return;

                reader.Read();

                imageInByte = (byte[])reader["IMAGE_FILE"];

                labelFileName.Text = "Выбранный файл: Изображения для " + reader.GetString(1);
                customTextBoxFullName.Text = reader.GetString(1);
                customCheckBox1.IsChecked = reader.GetBoolean(2);

                reader.Close();
            }
        }

        public FormImage(string pathToImage, string login)
        {
            InitializeComponent();
            
            imageInByte = ImageToByteArray(System.Drawing.Image.FromFile(pathToImage));
            this.login = login;

            labelFileName.Text = "Выбранный файл: " + PathToName(pathToImage);
        }

        private string PathToName(string path)
        {
            return path.Split('\\').Last().Split('.')[0];
        }

        private void customButtonSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Файлы изображения (*.jpg)|*.jpg";
            openFileDialog.DefaultExt = "Файлы изображения (*.jpg)|*.jpg";
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                
                FileInfo fi = new FileInfo(openFileDialog.FileName);
                long fileSize = fi.Length;

                if (fileSize <= 0.75 * 1024 * 1024)
                {
                    // Размер файла не превышает 0.75 МБ
                    labelFileName.Text = "Выбранный файл: " + PathToName(openFileDialog.FileName);
                    imageInByte = ImageToByteArray(System.Drawing.Image.FromFile(openFileDialog.FileName));
                }
                else
                {
                    // Размер файла превышает 0.75 МБ
                    MessageBox.Show("Размер выбранного файла превышает допустимую норму!", "Внимание");
                }
            }
        }

        private void customButtonOK_Click(object sender, EventArgs e)
        {
            if (imageInByte != null && customTextBoxFullName.Text.Length > 0)
            {
                using (var connection = new SqlConnection(Properties.Settings.Default.rv_facerecognitionConnectionString))
                {
                    connection.Open();

                    string query;
                    if (ImageId > 0)
                        query = "UPDATE IMAGES SET USER_LOGIN = @USER_LOGIN, IMAGE_FILE = @IMAGE_FILE, IMAGE_NAME = @IMAGE_NAME, DATE_UPDATE = @DATE_UPDATE, LEARNING_STATUS = @LEARNING_STATUS WHERE IMAGE_ID = @IMAGE_ID";
                    else
                        query = "INSERT INTO IMAGES (USER_LOGIN, IMAGE_FILE, IMAGE_NAME, LEARNING_STATUS) VALUES (@USER_LOGIN, @IMAGE_FILE, @IMAGE_NAME, @LEARNING_STATUS)";
                    
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.Add(new SqlParameter("@USER_LOGIN", SqlDbType.VarChar, 20) { Value = login });
                    command.Parameters.Add(new SqlParameter("@IMAGE_FILE", SqlDbType.VarBinary) { Value = imageInByte });
                    command.Parameters.Add(new SqlParameter("@IMAGE_NAME", SqlDbType.VarChar, 25) { Value = customTextBoxFullName.Text });
                    command.Parameters.Add(new SqlParameter("@LEARNING_STATUS", SqlDbType.Bit) { Value = customCheckBox1.IsChecked ? 1 : 0 });

                    if (ImageId > 0)
                    {
                        command.Parameters.Add(new SqlParameter("@IMAGE_ID", SqlDbType.Int) { Value = ImageId });
                        command.Parameters.Add(new SqlParameter("@DATE_UPDATE", SqlDbType.DateTime) { Value = DateTime.Now });
                    }

                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        if (ImageId > 0)
                            MessageBox.Show("Изображение успешно обновлено!", "Успех!");
                        else
                            MessageBox.Show("Изображение успешно добавлено!", "Успех!");

                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        if (ImageId > 0)
                            MessageBox.Show("При обновлении изображения возникла ошибка!", "Ошибка!");
                        else
                            MessageBox.Show("При добавлении изображения возникла ошибка!", "Ошибка!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Операция невозможна (изображение не выбрано или ФИО не введено)!", "Ошибка!");
                return;
            }
        }

        // Закрытие модального окна с результатом отмены
        private void customButtonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }
    }
}
