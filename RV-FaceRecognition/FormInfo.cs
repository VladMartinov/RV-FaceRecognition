using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RV_FaceRecognition
{
    public partial class FormInfo : Form
    {
        FormImage imageForm;

        public FormInfo()
        {
            InitializeComponent();
        }

        private void FormInfo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rv_facerecognitionDataSet.View_Images' table. You can move, or remove it, as needed.
            this.view_ImagesTableAdapter.Fill(this.rv_facerecognitionDataSet.View_Images);

        }

        private void customButtonAdd_Click(object sender, EventArgs e)
        {
            imageForm = new FormImage();
            imageForm.ShowDialog();
        }

        private void customButtonUpd_Click(object sender, EventArgs e)
        {
            imageForm = new FormImage();
            imageForm.ShowDialog();
        }
    }
}
