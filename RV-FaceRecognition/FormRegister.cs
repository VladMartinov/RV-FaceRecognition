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
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void CustomCheckBoxDeffault_Click(object sender, MouseEventArgs e)
        {
            if (!customCheckBoxDeffault.IsChecked)
                customCheckBoxAdmin.IsChecked = false;
        }

        private void CustomCheckBoxAdmin_Click(object sender, MouseEventArgs e)
        {
            if (!customCheckBoxAdmin.IsChecked)
                customCheckBoxDeffault.IsChecked = false;
        }
    }
}
