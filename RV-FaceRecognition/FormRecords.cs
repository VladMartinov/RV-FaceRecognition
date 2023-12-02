using System;
using System.Windows.Forms;

namespace RV_FaceRecognition
{
    public partial class FormRecords : Form
    {
        private string login;

        public FormRecords(string login)
        {
            InitializeComponent();
            this.login = login;
        }

        private void FormRecords_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rv_facerecognitionDataSet.View_Records' table. You can move, or remove it, as needed.
            this.view_RecordsTableAdapter.Fill(this.rv_facerecognitionDataSet.View_Records);
        }

        private void customButtonStatistic_Click(object sender, EventArgs e)
        {
            FormStatistic formStatistic = new FormStatistic(this.login);
            formStatistic.ShowDialog();
        }
    }
}
