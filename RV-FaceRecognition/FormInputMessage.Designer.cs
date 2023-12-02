namespace RV_FaceRecognition
{
    partial class FormInputMessage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInputMessage));
            this.rvFormStyle1 = new RV_FaceRecognition.Components.RVFormStyle(this.components);
            this.labelMain = new System.Windows.Forms.Label();
            this.customTextBoxInput = new RV_FaceRecognition.Components.Controls.CustomTextBox();
            this.customButtonOK = new RV_FaceRecognition.Components.Controls.CustomButton();
            this.customButtonCancel = new RV_FaceRecognition.Components.Controls.CustomButton();
            this.SuspendLayout();
            // 
            // rvFormStyle1
            // 
            this.rvFormStyle1.Form = this;
            this.rvFormStyle1.FormStyle = RV_FaceRecognition.Components.RVFormStyle.fStyle.UserStyle;
            // 
            // labelMain
            // 
            this.labelMain.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMain.ForeColor = System.Drawing.Color.White;
            this.labelMain.Location = new System.Drawing.Point(20, 20);
            this.labelMain.Name = "labelMain";
            this.labelMain.Size = new System.Drawing.Size(255, 19);
            this.labelMain.TabIndex = 0;
            this.labelMain.Text = "Текст Текст Текст...";
            this.labelMain.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // customTextBoxInput
            // 
            this.customTextBoxInput.Font = new System.Drawing.Font("Open Sans", 10F, System.Drawing.FontStyle.Bold);
            this.customTextBoxInput.FontTextPreview = new System.Drawing.Font("Open Sans", 10F);
            this.customTextBoxInput.ForeColor = System.Drawing.Color.White;
            this.customTextBoxInput.Location = new System.Drawing.Point(20, 50);
            this.customTextBoxInput.MaxLength = 20;
            this.customTextBoxInput.Name = "customTextBoxInput";
            this.customTextBoxInput.Size = new System.Drawing.Size(255, 20);
            this.customTextBoxInput.TabIndex = 1;
            this.customTextBoxInput.TextInput = "";
            this.customTextBoxInput.UseSystemPasswordChar = false;
            // 
            // customButtonOK
            // 
            this.customButtonOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(189)))));
            this.customButtonOK.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customButtonOK.ForeColor = System.Drawing.Color.White;
            this.customButtonOK.Location = new System.Drawing.Point(20, 86);
            this.customButtonOK.Name = "customButtonOK";
            this.customButtonOK.Rounding = 20;
            this.customButtonOK.RoundingEnable = true;
            this.customButtonOK.Size = new System.Drawing.Size(100, 25);
            this.customButtonOK.TabIndex = 6;
            this.customButtonOK.Text = "ОК";
            this.customButtonOK.Click += new System.EventHandler(this.customButtonOK_Click);
            // 
            // customButtonCancel
            // 
            this.customButtonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(189)))));
            this.customButtonCancel.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customButtonCancel.ForeColor = System.Drawing.Color.White;
            this.customButtonCancel.Location = new System.Drawing.Point(175, 86);
            this.customButtonCancel.Name = "customButtonCancel";
            this.customButtonCancel.Rounding = 20;
            this.customButtonCancel.RoundingEnable = true;
            this.customButtonCancel.Size = new System.Drawing.Size(100, 25);
            this.customButtonCancel.TabIndex = 7;
            this.customButtonCancel.Text = "Отмена";
            this.customButtonCancel.Click += new System.EventHandler(this.customButtonCancel_Click);
            // 
            // FormInputMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(112)))), ((int)(((byte)(139)))));
            this.ClientSize = new System.Drawing.Size(279, 118);
            this.Controls.Add(this.customButtonCancel);
            this.Controls.Add(this.customButtonOK);
            this.Controls.Add(this.customTextBoxInput);
            this.Controls.Add(this.labelMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(295, 157);
            this.MinimumSize = new System.Drawing.Size(295, 157);
            this.Name = "FormInputMessage";
            this.Text = "RV Face Recognition";
            this.ResumeLayout(false);

        }

        #endregion

        private Components.RVFormStyle rvFormStyle1;
        private Components.Controls.CustomTextBox customTextBoxInput;
        private System.Windows.Forms.Label labelMain;
        private Components.Controls.CustomButton customButtonOK;
        private Components.Controls.CustomButton customButtonCancel;
    }
}