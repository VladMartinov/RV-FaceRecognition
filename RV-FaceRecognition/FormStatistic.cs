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
        private int usersId;

        public FormStatistic(int usersId)
        {
            InitializeComponent();

            this.usersId = usersId;
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
            // Открываем подключение к базе данных
            connection.Open();

            // Создаем команду для выполнения процедуры
            SqlCommand command = new SqlCommand("STATISTICS_FOR_ALL_ACTIONS", connection)
            {
                CommandType = CommandType.StoredProcedure
            };

            SqlDataReader reader = command.ExecuteReader();

            // Очисщаем данные в Chart1
            chart1.Series["se1"].Points.Clear();
            chart1.ChartAreas[0].BackColor = Color.Transparent;

            // Прочитаем данные из результата процедуры и добавим их в Chart1
            while (reader.Read())
            {
                string actionName = reader["ACTION_NAME"].ToString();
                int count = Convert.ToInt32(reader["COUNT"]);

                chart1.Series["se1"].Points.AddXY(actionName, count);
            }

            // Закроем чтение данных
            reader.Close();

            // Закроем подключение к базе данных
            connection.Close();
        }

        private void FillChart2()
        {
            // Откроем подключение к базе данных
            connection.Open();

            // Создаем команду для выполнения процедуры
            SqlCommand command = new SqlCommand("STATISTICS_ACTIONS_BY_USER", connection)
            {
                CommandType = CommandType.StoredProcedure
            };

            // Добавим параметр для процедуры
            command.Parameters.AddWithValue("@USERS_ID", usersId);

            SqlDataReader reader = command.ExecuteReader();

            // Очистим данные в Chart2
            chart2.Series["se2"].Points.Clear();
            chart2.ChartAreas[0].BackColor = Color.Transparent;

            // Прочитаем данные из результата процедуры и добавим их в Chart2
            while (reader.Read())
            {
                string actionName = reader["ACTION_NAME"].ToString();
                int count = Convert.ToInt32(reader["COUNT"]);

                chart2.Series["se2"].Points.AddXY(actionName, count);
            }
            

            // Закроем чтение данных
            reader.Close();

            // Закроем подключение к базе данных
            connection.Close();
        }
    }
}
