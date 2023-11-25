namespace RV_FaceRecognition
{
    partial class FormImage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormImage));
            this.labelFileName = new System.Windows.Forms.Label();
            this.labelFullName = new System.Windows.Forms.Label();
            this.customButtonCancel = new RV_FaceRecognition.Components.Controls.CustomButton();
            this.customButtonOK = new RV_FaceRecognition.Components.Controls.CustomButton();
            this.customCheckBox1 = new RV_FaceRecognition.Components.Controls.CustomCheckBox();
            this.customTextBoxFullName = new RV_FaceRecognition.Components.Controls.CustomTextBox();
            this.customButtonSelectFile = new RV_FaceRecognition.Components.Controls.CustomButton();
            this.rvFormStyle1 = new RV_FaceRecognition.Components.RVFormStyle(this.components);
            this.SuspendLayout();
            // 
            // labelFileName
            // 
            this.labelFileName.AutoSize = true;
            this.labelFileName.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFileName.ForeColor = System.Drawing.Color.White;
            this.labelFileName.Location = new System.Drawing.Point(20, 30);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(116, 15);
            this.labelFileName.TabIndex = 0;
            this.labelFileName.Text = "Выбранный файл: ...";
            // 
            // labelFullName
            // 
            this.labelFullName.AutoSize = true;
            this.labelFullName.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFullName.ForeColor = System.Drawing.Color.White;
            this.labelFullName.Location = new System.Drawing.Point(20, 103);
            this.labelFullName.Name = "labelFullName";
            this.labelFullName.Size = new System.Drawing.Size(136, 15);
            this.labelFullName.TabIndex = 2;
            this.labelFullName.Text = "Фамилия/Имя/Отчество";
            // 
            // customButtonCancel
            // 
            this.customButtonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(189)))));
            this.customButtonCancel.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customButtonCancel.ForeColor = System.Drawing.Color.White;
            this.customButtonCancel.Location = new System.Drawing.Point(191, 261);
            this.customButtonCancel.Name = "customButtonCancel";
            this.customButtonCancel.Rounding = 20;
            this.customButtonCancel.RoundingEnable = true;
            this.customButtonCancel.Size = new System.Drawing.Size(100, 25);
            this.customButtonCancel.TabIndex = 6;
            this.customButtonCancel.Text = "Отмена";
            this.customButtonCancel.Click += new System.EventHandler(this.customButtonCancel_Click);
            // 
            // customButtonOK
            // 
            this.customButtonOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(189)))));
            this.customButtonOK.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customButtonOK.ForeColor = System.Drawing.Color.White;
            this.customButtonOK.Location = new System.Drawing.Point(20, 261);
            this.customButtonOK.Name = "customButtonOK";
            this.customButtonOK.Rounding = 20;
            this.customButtonOK.RoundingEnable = true;
            this.customButtonOK.Size = new System.Drawing.Size(100, 25);
            this.customButtonOK.TabIndex = 5;
            this.customButtonOK.Text = "ОК";
            // 
            // customCheckBox1
            // 
            this.customCheckBox1.CheckBoxBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(189)))));
            this.customCheckBox1.CheckBoxFont = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customCheckBox1.CheckBoxFrameColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(189)))));
            this.customCheckBox1.CheckBoxFrameStrength = 1;
            this.customCheckBox1.CheckBoxSize = 15;
            this.customCheckBox1.CheckBoxText = "Обучено";
            this.customCheckBox1.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customCheckBox1.ForeColor = System.Drawing.Color.White;
            this.customCheckBox1.IsChecked = false;
            this.customCheckBox1.Location = new System.Drawing.Point(20, 175);
            this.customCheckBox1.Name = "customCheckBox1";
            this.customCheckBox1.OnceActive = false;
            this.customCheckBox1.Size = new System.Drawing.Size(112, 35);
            this.customCheckBox1.TabIndex = 4;
            this.customCheckBox1.Text = "Обучено";
            // 
            // customTextBoxFullName
            // 
            this.customTextBoxFullName.Font = new System.Drawing.Font("Open Sans", 10F, System.Drawing.FontStyle.Bold);
            this.customTextBoxFullName.FontTextPreview = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customTextBoxFullName.ForeColor = System.Drawing.Color.White;
            this.customTextBoxFullName.Location = new System.Drawing.Point(20, 125);
            this.customTextBoxFullName.MaxLength = 25;
            this.customTextBoxFullName.Name = "customTextBoxFullName";
            this.customTextBoxFullName.Size = new System.Drawing.Size(271, 20);
            this.customTextBoxFullName.TabIndex = 3;
            this.customTextBoxFullName.TextInput = "";
            this.customTextBoxFullName.UseSystemPasswordChar = false;
            // 
            // customButtonSelectFile
            // 
            this.customButtonSelectFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(189)))));
            this.customButtonSelectFile.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.customButtonSelectFile.ForeColor = System.Drawing.Color.White;
            this.customButtonSelectFile.Location = new System.Drawing.Point(23, 52);
            this.customButtonSelectFile.Name = "customButtonSelectFile";
            this.customButtonSelectFile.Rounding = 20;
            this.customButtonSelectFile.RoundingEnable = true;
            this.customButtonSelectFile.Size = new System.Drawing.Size(271, 25);
            this.customButtonSelectFile.TabIndex = 1;
            this.customButtonSelectFile.Text = "Выбрать файл";
            // 
            // rvFormStyle1
            // 
            this.rvFormStyle1.Form = this;
            this.rvFormStyle1.FormStyle = RV_FaceRecognition.Components.RVFormStyle.fStyle.UserStyle;
            // 
            // FormImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(112)))), ((int)(((byte)(139)))));
            this.ClientSize = new System.Drawing.Size(295, 293);
            this.Controls.Add(this.customButtonCancel);
            this.Controls.Add(this.customButtonOK);
            this.Controls.Add(this.customCheckBox1);
            this.Controls.Add(this.customTextBoxFullName);
            this.Controls.Add(this.labelFullName);
            this.Controls.Add(this.customButtonSelectFile);
            this.Controls.Add(this.labelFileName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(311, 332);
            this.MinimumSize = new System.Drawing.Size(311, 332);
            this.Name = "FormImage";
            this.Text = "RV Face Recognition";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Components.RVFormStyle rvFormStyle1;
        private Components.Controls.CustomButton customButtonSelectFile;
        private System.Windows.Forms.Label labelFileName;
        private Components.Controls.CustomTextBox customTextBoxFullName;
        private System.Windows.Forms.Label labelFullName;
        private Components.Controls.CustomCheckBox customCheckBox1;
        private Components.Controls.CustomButton customButtonCancel;
        private Components.Controls.CustomButton customButtonOK;
    }
}