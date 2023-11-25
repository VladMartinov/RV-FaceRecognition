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
    public partial class FormImage : Form
    {
        public FormImage()
        {
            InitializeComponent();
        }

        // Закрытие модального окна с результатом отмены
        private void customButtonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
