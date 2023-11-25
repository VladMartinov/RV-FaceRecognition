using System;
using System.Windows.Forms;

namespace RV_FaceRecognition
{
    public partial class FormInputMessage : Form
    {
        private string inputValue;
        public string input
        {
            get => this.inputValue;
        }

        public FormInputMessage(string title = "Введите значение:")
        {
            InitializeComponent();

            labelMain.Text = title;
        }

        private void SendResult()
        {
            if (inputValue == "") return;

            this.DialogResult = DialogResult.OK;
            this.inputValue = this.customTextBoxInput.Text;
            this.Close();
        }

        private void CloseModal()
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void customButtonCancel_Click(object sender, EventArgs e)
        {
            CloseModal();
        }

        private void customButtonOK_Click(object sender, EventArgs e)
        {
            SendResult();
        }
    }
}
