namespace RV_FaceRecognition
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.customTextBoxPassword = new RV_FaceRecognition.Components.Controls.CustomTextBox();
            this.customTextBoxLogin = new RV_FaceRecognition.Components.Controls.CustomTextBox();
            this.rvFormStyle1 = new RV_FaceRecognition.Components.RVFormStyle(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.customButtonLogIn = new RV_FaceRecognition.Components.Controls.CustomButton();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxPassword = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(112)))), ((int)(((byte)(139)))));
            this.pictureBox1.BackgroundImage = global::RV_FaceRecognition.Properties.Resources.Auth_Logo;
            this.pictureBox1.Location = new System.Drawing.Point(146, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 125);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // customTextBoxPassword
            // 
            this.customTextBoxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.customTextBoxPassword.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customTextBoxPassword.FontTextPreview = new System.Drawing.Font("Open Sans", 10F);
            this.customTextBoxPassword.ForeColor = System.Drawing.Color.White;
            this.customTextBoxPassword.Location = new System.Drawing.Point(72, 304);
            this.customTextBoxPassword.MaxLength = 20;
            this.customTextBoxPassword.Name = "customTextBoxPassword";
            this.customTextBoxPassword.Size = new System.Drawing.Size(255, 20);
            this.customTextBoxPassword.TabIndex = 2;
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
            this.customTextBoxLogin.TabIndex = 1;
            this.customTextBoxLogin.TextInput = "Login";
            this.customTextBoxLogin.UseSystemPasswordChar = false;
            // 
            // rvFormStyle1
            // 
            this.rvFormStyle1.Form = this;
            this.rvFormStyle1.FormStyle = RV_FaceRecognition.Components.RVFormStyle.fStyle.UserStyle;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(200, 327);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Don\'t have an account?\n";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // customButtonLogIn
            // 
            this.customButtonLogIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(189)))));
            this.customButtonLogIn.Font = new System.Drawing.Font("Open Sans", 12F);
            this.customButtonLogIn.ForeColor = System.Drawing.Color.White;
            this.customButtonLogIn.Location = new System.Drawing.Point(87, 390);
            this.customButtonLogIn.Name = "customButtonLogIn";
            this.customButtonLogIn.Rounding = 13;
            this.customButtonLogIn.RoundingEnable = true;
            this.customButtonLogIn.Size = new System.Drawing.Size(225, 40);
            this.customButtonLogIn.TabIndex = 4;
            this.customButtonLogIn.Text = "Log In";
            this.customButtonLogIn.Click += new System.EventHandler(this.customButtonLogIn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(69, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Forgot the password";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBoxPassword
            // 
            this.pictureBoxPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxPassword.Location = new System.Drawing.Point(333, 299);
            this.pictureBoxPassword.Name = "pictureBoxPassword";
            this.pictureBoxPassword.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxPassword.TabIndex = 13;
            this.pictureBoxPassword.TabStop = false;
            this.pictureBoxPassword.Click += new System.EventHandler(this.pictureBoxPassword_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(112)))), ((int)(((byte)(139)))));
            this.ClientSize = new System.Drawing.Size(384, 451);
            this.Controls.Add(this.pictureBoxPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.customButtonLogIn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customTextBoxPassword);
            this.Controls.Add(this.customTextBoxLogin);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(400, 490);
            this.MinimumSize = new System.Drawing.Size(400, 490);
            this.Name = "FormLogin";
            this.Text = "RV Face Recognition";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Components.RVFormStyle rvFormStyle1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Components.Controls.CustomTextBox customTextBoxLogin;
        private Components.Controls.CustomTextBox customTextBoxPassword;
        private System.Windows.Forms.Label label1;
        private Components.Controls.CustomButton customButtonLogIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxPassword;
    }
}