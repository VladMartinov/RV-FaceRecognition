using RV_FaceRecognition.Components.Methods;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RV_FaceRecognition
{
    public partial class FormInfo : Form
    {
        private int usersId;
        private string userLogin;
        private FormImage imageForm;

        public FormInfo(int usersId, int userRole)
        {
            InitializeComponent();
            this.usersId = usersId;

            UsersDatabase usersDatabase = new UsersDatabase(this.usersId, Properties.Settings.Default.rv_facerecognitionConnectionString);
            this.userLogin = usersDatabase.GetUserLogin();

            dataGridView1.RowTemplate.Height = 200;

            if (userRole != 1) return;

            customButtonAdd.Enabled = false;
            customButtonUpd.Enabled = false;
            customButtonDel.Enabled = false;
        }

        private async void FormInfo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rv_facerecognitionDataSet.View_Images' table. You can move, or remove it, as needed.
            await UpdateGrid();
        }

        // Открываем окно добавления нового изображения
        private async void customButtonAdd_Click(object sender, EventArgs e)
        {
            imageForm = new FormImage(usersId);
            imageForm.ShowDialog();

            if (imageForm.DialogResult == DialogResult.OK)
            {
                await UpdateGrid();

                RecordsManager recordsManager = new RecordsManager(usersId);
                recordsManager.RegisterAction(TypeActiom.AddImage, $"Пользователь \"{userLogin}\" добавил изображение с именем \"{imageForm.NameRow}\"");
            }
        }

        // Открываем окно обновления существующего изображения
        private async void customButtonUpd_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count <= 0) return;
            if (dataGridView1.SelectedRows.Count > 1)
            {
                MessageBox.Show($"Пожалуйста, выберите 1-но поле для обновления (сейчас выбрано {dataGridView1.SelectedRows.Count}).", "Уведомление.");
                return;
            }
            
            imageForm = new FormImage(usersId, (int) dataGridView1.SelectedRows[0].Cells[0].Value);
            imageForm.ShowDialog();

            if (imageForm.DialogResult == DialogResult.OK)
            {
                await UpdateGrid();

                RecordsManager recordsManager = new RecordsManager(this.usersId);
                recordsManager.RegisterAction(TypeActiom.UpdateImage, $"Пользователь \"{userLogin}\" обновил изображение с именем \"{imageForm.NameRow}\"");
            }
        }

        // Удаляем выбранные изображения из базы данных
        private async void customButtonDel_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count < 0) return;

            bool isUpdate = false;

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                var answer = MessageBox.Show($"Вы уверены что хотите удалить это поле: {row.Cells[2].Value} ?", "Подтверждение действия", MessageBoxButtons.YesNo);
                if (answer == DialogResult.Yes)
                {
                    using (var connection = new SqlConnection(Properties.Settings.Default.rv_facerecognitionConnectionString))
                    {
                        connection.Open();

                        string query = "DELETE FROM IMAGES WHERE IMAGE_ID = @IMAGE_ID";

                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.Add(new SqlParameter("@IMAGE_ID", SqlDbType.Int) { Value = row.Cells[0].Value });

                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Изображение успешно удалено!", "Успех!");

                            RecordsManager recordsManager = new RecordsManager(usersId);
                            recordsManager.RegisterAction(TypeActiom.DeleteImage, $"Пользователь \"{userLogin}\" удалил изображение с именем \"{row.Cells[2].Value}\"");
                        }
                        else
                            MessageBox.Show("При удалении изображения возникла ошибка!", "Ошибка!");
                    }

                    isUpdate = true;
                }
            }

            if (isUpdate)
                await UpdateGrid();
        }

        // Обновляем содержимое таблицы ассинхронно (чтобы программа не зависала в случае большого количества файлов)
        private async Task UpdateGrid()
        {
            await Task.Run(() =>
            {
                this.Invoke(new MethodInvoker(delegate ()
                {
                    this.view_ImagesTableAdapter.Fill(this.rv_facerecognitionDataSet.View_Images);
                }));
            });
        }
    }
}
