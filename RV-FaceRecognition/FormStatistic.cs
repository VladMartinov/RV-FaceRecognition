using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;

namespace RV_FaceRecognition
{
    public partial class FormStatistic : Form
    {
        private SqlConnection connection;
        private string login;

        public FormStatistic(string login)
        {
            InitializeComponent();

            this.login = login;
            this.connection = new SqlConnection(Properties.Settings.Default.rv_facerecognitionConnectionString);
        }

        private void FormStatistic_Load(object sender, EventArgs e)
        {
            // Заполните Chart1
            FillChart1();

            // Заполните Chart2
            FillChart2();
        }

        private void FillChart1()
        {
            // Откройте подключение к базе данных
            connection.Open();

            // Создайте команду для выполнения процедуры
            SqlCommand command = new SqlCommand("STATISTICS_FOR_ALL_ACTIONS", connection);
            command.CommandType = CommandType.StoredProcedure;

            SqlDataReader reader = command.ExecuteReader();

            // Очистите данные в Chart1
            chart1.Series["se1"].Points.Clear();
            chart1.ChartAreas[0].BackColor = Color.Transparent;

            // Прочитайте данные из результата процедуры и добавьте их в Chart1
            while (reader.Read())
            {
                string actionName = reader["ACTION_NAME"].ToString();
                int count = Convert.ToInt32(reader["COUNT"]);

                chart1.Series["se1"].Points.AddXY(actionName, count);
            }

            // Закройте чтение данных
            reader.Close();

            // Закройте подключение к базе данных
            connection.Close();
        }

        private void FillChart2()
        {
            // Откройте подключение к базе данных
            connection.Open();

            // Создайте команду для выполнения процедуры
            SqlCommand command = new SqlCommand("STATISTICS_ACTIONS_BY_USER", connection);
            command.CommandType = CommandType.StoredProcedure;

            // Добавьте параметр для процедуры
            command.Parameters.AddWithValue("@USER_LOGIN", this.login);

            SqlDataReader reader = command.ExecuteReader();

            // Очистите данные в Chart2
            chart2.Series["se2"].Points.Clear();
            chart2.ChartAreas[0].BackColor = Color.Transparent;

            // Прочитайте данные из результата процедуры и добавьте их в Chart2
            while (reader.Read())
            {
                string actionName = reader["ACTION_NAME"].ToString();
                int count = Convert.ToInt32(reader["COUNT"]);

                chart2.Series["se2"].Points.AddXY(actionName, count);
            }
            

            // Закройте чтение данных
            reader.Close();

            // Закройте подключение к базе данных
            connection.Close();
        }
    }
}
