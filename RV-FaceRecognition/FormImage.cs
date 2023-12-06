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
        private int usersId;

        private byte[] imageInByte;

        private string nameRow;
        public string NameRow
        {
            get => nameRow;
        }

        private int ImageId = -1;
        #endregion


        // В сулчае если создаем новый экземпляр сущнсоти
        public FormImage(int usersId)
        {
            InitializeComponent();
            this.usersId = usersId;
        }

        // В сулчае если получаем ID изображения, мы получаем его из БД и заполняем поля
        public FormImage(int usersId, int ID)
        {
            InitializeComponent();

            ImageId = ID;
            this.usersId = usersId;

            using (var connection = new SqlConnection(Properties.Settings.Default.rv_facerecognitionConnectionString))
            {
                connection.Open();

                string query = "SELECT IMAGE_FILE, IMAGE_NAME FROM IMAGES WHERE IMAGE_ID = @IMAGE_ID";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IMAGE_ID", ImageId);

                SqlDataReader reader = command.ExecuteReader();

                if (!reader.HasRows) return;

                reader.Read();

                imageInByte = (byte[])reader["IMAGE_FILE"];

                labelFileName.Text = "Выбранный файл: Изображения для " + reader.GetString(1);
                customTextBoxFullName.Text = reader.GetString(1);

                reader.Close();
            }
        }

        // В случае если мы получили изображение при нажатии на кнопку "Добавить изображение" в главном меню и выбрали пункт добавить в БД
        public FormImage(string pathToImage, int usersId)
        {
            InitializeComponent();
            
            imageInByte = ImageToByteArray(System.Drawing.Image.FromFile(pathToImage));
            this.usersId = usersId;

            labelFileName.Text = "Выбранный файл: " + PathToName(pathToImage);
        }

        // Получаем наименование файла
        private string PathToName(string path)
        {
            return path.Split('\\').Last().Split('.')[0];
        }

        // При нажатии на кнопку выбора файла появляется окно проводника где пользователь выбирает файл формата .jpg размером < 0.75
        private void CustomButtonSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Файлы изображения (*.jpg)|*.jpg",
                DefaultExt = "Файлы изображения (*.jpg)|*.jpg",
                RestoreDirectory = true
            };

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

        // Отправка либо измененного либо нового экземпляра сущности изображения в базу данных
        private void CustomButtonOK_Click(object sender, EventArgs e)
        {
            if (imageInByte != null)
            {
                using (var connection = new SqlConnection(Properties.Settings.Default.rv_facerecognitionConnectionString))
                {
                    connection.Open();

                    string query;
                    if (ImageId > 0)
                        query = "UPDATE IMAGES SET USERS_ID = @USERS_ID, IMAGE_FILE = @IMAGE_FILE, IMAGE_NAME = @IMAGE_NAME, DATE_UPDATE = @DATE_UPDATE WHERE IMAGE_ID = @IMAGE_ID";
                    else
                        query = "INSERT INTO IMAGES (USERS_ID, IMAGE_FILE, IMAGE_NAME) VALUES (@USERS_ID, @IMAGE_FILE, @IMAGE_NAME)";
                    
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.Add(new SqlParameter("@USERS_ID", SqlDbType.Int) { Value = usersId });
                    command.Parameters.Add(new SqlParameter("@IMAGE_FILE", SqlDbType.VarBinary) { Value = imageInByte });
                    command.Parameters.Add(new SqlParameter("@IMAGE_NAME", SqlDbType.VarChar, 25) { Value = customTextBoxFullName.Text });

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

                        this.nameRow = customTextBoxFullName.Text;
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
        private void CustomButtonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        // Конвертация изображения в байты для отправки в БД
        private byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.ToArray();
        }
    }
}
