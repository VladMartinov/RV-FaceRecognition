namespace RV_FaceRecognition
{
    partial class FormRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegister));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.customCheckBoxAdmin = new RV_FaceRecognition.Components.Controls.CustomCheckBox();
            this.customCheckBoxDeffault = new RV_FaceRecognition.Components.Controls.CustomCheckBox();
            this.customButtonRegister = new RV_FaceRecognition.Components.Controls.CustomButton();
            this.customTextBoxPassword = new RV_FaceRecognition.Components.Controls.CustomTextBox();
            this.customTextBoxLogin = new RV_FaceRecognition.Components.Controls.CustomTextBox();
            this.rvFormStyle1 = new RV_FaceRecognition.Components.RVFormStyle(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(112)))), ((int)(((byte)(139)))));
            this.pictureBox1.BackgroundImage = global::RV_FaceRecognition.Properties.Resources.Auth_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(146, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 125);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // customCheckBoxAdmin
            // 
            this.customCheckBoxAdmin.CheckBoxBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(189)))));
            this.customCheckBoxAdmin.CheckBoxFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customCheckBoxAdmin.CheckBoxFrameColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(189)))));
            this.customCheckBoxAdmin.CheckBoxFrameStrength = 1;
            this.customCheckBoxAdmin.CheckBoxSize = 15;
            this.customCheckBoxAdmin.CheckBoxText = "Администратор";
            this.customCheckBoxAdmin.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customCheckBoxAdmin.ForeColor = System.Drawing.Color.White;
            this.customCheckBoxAdmin.IsChecked = false;
            this.customCheckBoxAdmin.Location = new System.Drawing.Point(217, 346);
            this.customCheckBoxAdmin.Name = "customCheckBoxAdmin";
            this.customCheckBoxAdmin.Size = new System.Drawing.Size(110, 20);
            this.customCheckBoxAdmin.TabIndex = 11;
            this.customCheckBoxAdmin.Text = "customCheckBox2";
            this.customCheckBoxAdmin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CustomCheckBoxAdmin_Click);
            // 
            // customCheckBoxDeffault
            // 
            this.customCheckBoxDeffault.CheckBoxBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(189)))));
            this.customCheckBoxDeffault.CheckBoxFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customCheckBoxDeffault.CheckBoxFrameColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(189)))));
            this.customCheckBoxDeffault.CheckBoxFrameStrength = 1;
            this.customCheckBoxDeffault.CheckBoxSize = 15;
            this.customCheckBoxDeffault.CheckBoxText = "Обычный";
            this.customCheckBoxDeffault.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customCheckBoxDeffault.ForeColor = System.Drawing.Color.White;
            this.customCheckBoxDeffault.IsChecked = true;
            this.customCheckBoxDeffault.Location = new System.Drawing.Point(72, 346);
            this.customCheckBoxDeffault.Name = "customCheckBoxDeffault";
            this.customCheckBoxDeffault.Size = new System.Drawing.Size(110, 20);
            this.customCheckBoxDeffault.TabIndex = 10;
            this.customCheckBoxDeffault.Text = "customCheckBox1";
            this.customCheckBoxDeffault.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CustomCheckBoxDeffault_Click);
            // 
            // customButtonRegister
            // 
            this.customButtonRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(189)))));
            this.customButtonRegister.Font = new System.Drawing.Font("Open Sans", 12F);
            this.customButtonRegister.ForeColor = System.Drawing.Color.White;
            this.customButtonRegister.Location = new System.Drawing.Point(87, 390);
            this.customButtonRegister.Name = "customButtonRegister";
            this.customButtonRegister.Rounding = 13;
            this.customButtonRegister.RoundingEnable = true;
            this.customButtonRegister.Size = new System.Drawing.Size(225, 40);
            this.customButtonRegister.TabIndex = 9;
            this.customButtonRegister.Text = "Register";
            // 
            // customTextBoxPassword
            // 
            this.customTextBoxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.customTextBoxPassword.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customTextBoxPassword.FontTextPreview = new System.Drawing.Font("Open Sans", 10F);
            this.customTextBoxPassword.ForeColor = System.Drawing.Color.White;
            this.customTextBoxPassword.Location = new System.Drawing.Point(72, 304);
            this.customTextBoxPassword.MaxLength = 20;
            this.customTextBoxPassword.Name = "customTextBoxPassword";
            this.customTextBoxPassword.Size = new System.Drawing.Size(255, 20);
            this.customTextBoxPassword.TabIndex = 7;
            this.customTextBoxPassword.TextInput = "Password";
            this.customTextBoxPassword.UseSystemPasswordChar = true;
            // 
            // customTextBoxLogin
            // 
            this.customTextBoxLogin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.customTextBoxLogin.Font = new System.Drawing.Font("Open Sans", 10F, System.Drawing.FontStyle.Bold);
            this.customTextBoxLogin.FontTextPreview = new System.Drawing.Font("Open Sans", 10F);
            this.customTextBoxLogin.ForeColor = System.Drawing.Color.White;
            this.customTextBoxLogin.Location = new System.Drawing.Point(72, 257);
            this.customTextBoxLogin.MaxLength = 20;
            this.customTextBoxLogin.Name = "customTextBoxLogin";
            this.customTextBoxLogin.Size = new System.Drawing.Size(255, 20);
            this.customTextBoxLogin.TabIndex = 6;
            this.customTextBoxLogin.TextInput = "Login";
            this.customTextBoxLogin.UseSystemPasswordChar = false;
            // 
            // rvFormStyle1
            // 
            this.rvFormStyle1.Form = this;
            this.rvFormStyle1.FormStyle = RV_FaceRecognition.Components.RVFormStyle.fStyle.UserStyle;
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(112)))), ((int)(((byte)(139)))));
            this.ClientSize = new System.Drawing.Size(384, 451);
            this.Controls.Add(this.customCheckBoxAdmin);
            this.Controls.Add(this.customCheckBoxDeffault);
            this.Controls.Add(this.customButtonRegister);
            this.Controls.Add(this.customTextBoxPassword);
            this.Controls.Add(this.customTextBoxLogin);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(400, 490);
            this.MinimumSize = new System.Drawing.Size(400, 490);
            this.Name = "FormRegister";
            this.Text = "RV Face Recognition";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Components.RVFormStyle rvFormStyle1;
        private Components.Controls.CustomButton customButtonRegister;
        private Components.Controls.CustomTextBox customTextBoxPassword;
        private Components.Controls.CustomTextBox customTextBoxLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Components.Controls.CustomCheckBox customCheckBoxDeffault;
        private Components.Controls.CustomCheckBox customCheckBoxAdmin;
    }
}