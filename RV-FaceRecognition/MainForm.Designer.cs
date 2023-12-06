namespace RV_FaceRecognition
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.labelActions = new System.Windows.Forms.Label();
            this.customButtonAddImage = new RV_FaceRecognition.Components.Controls.CustomButton();
            this.roundedTableLayoutPanel = new RV_FaceRecognition.Components.Controls.RoundedTableLayoutPanel();
            this.labelRole = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.customButtonAuth = new RV_FaceRecognition.Components.Controls.CustomButton();
            this.customButtonTrain = new RV_FaceRecognition.Components.Controls.CustomButton();
            this.customButtonInfoWindow = new RV_FaceRecognition.Components.Controls.CustomButton();
            this.customButtonDetect = new RV_FaceRecognition.Components.Controls.CustomButton();
            this.customButtonCamera = new RV_FaceRecognition.Components.Controls.CustomButton();
            this.roundedPictureBox1 = new RV_FaceRecognition.Components.Controls.RoundedPictureBox();
            this.mainFormStyle = new RV_FaceRecognition.Components.RVFormStyle(this.components);
            this.mainRoundingButtonsComponent = new RV_FaceRecognition.Components.RoundingButtonsComponent(this.components);
            this.customButtonRecords = new RV_FaceRecognition.Components.Controls.CustomButton();
            this.roundedTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roundedPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelActions
            // 
            this.labelActions.AutoSize = true;
            this.labelActions.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelActions.ForeColor = System.Drawing.Color.White;
            this.labelActions.Location = new System.Drawing.Point(575, 20);
            this.labelActions.Name = "labelActions";
            this.labelActions.Size = new System.Drawing.Size(184, 23);
            this.labelActions.TabIndex = 1;
            this.labelActions.Text = "Панель инструментов";
            // 
            // customButtonAddImage
            // 
            this.customButtonAddImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(189)))));
            this.customButtonAddImage.Font = new System.Drawing.Font("Open Sans", 12F);
            this.customButtonAddImage.ForeColor = System.Drawing.Color.White;
            this.customButtonAddImage.Location = new System.Drawing.Point(554, 156);
            this.customButtonAddImage.Name = "customButtonAddImage";
            this.customButtonAddImage.Rounding = 13;
            this.customButtonAddImage.RoundingEnable = true;
            this.customButtonAddImage.Size = new System.Drawing.Size(225, 40);
            this.customButtonAddImage.TabIndex = 9;
            this.customButtonAddImage.Text = "Добавить изображение";
            this.customButtonAddImage.Click += new System.EventHandler(this.customButtonAddImage_Click);
            // 
            // roundedTableLayoutPanel
            // 
            this.roundedTableLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.roundedTableLayoutPanel.ColumnCount = 2;
            this.roundedTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.roundedTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.roundedTableLayoutPanel.Controls.Add(this.labelRole, 1, 0);
            this.roundedTableLayoutPanel.Controls.Add(this.labelLogin, 0, 0);
            this.roundedTableLayoutPanel.ForeColor = System.Drawing.Color.Black;
            this.roundedTableLayoutPanel.Location = new System.Drawing.Point(554, 385);
            this.roundedTableLayoutPanel.Name = "roundedTableLayoutPanel";
            this.roundedTableLayoutPanel.Rounding = 25;
            this.roundedTableLayoutPanel.RoundingEnable = true;
            this.roundedTableLayoutPanel.RowCount = 1;
            this.roundedTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.72414F));
            this.roundedTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.27586F));
            this.roundedTableLayoutPanel.Size = new System.Drawing.Size(225, 20);
            this.roundedTableLayoutPanel.TabIndex = 8;
            // 
            // labelRole
            // 
            this.labelRole.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelRole.AutoSize = true;
            this.labelRole.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRole.ForeColor = System.Drawing.Color.White;
            this.labelRole.Location = new System.Drawing.Point(115, 0);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(107, 20);
            this.labelRole.TabIndex = 1;
            this.labelRole.Text = "Роль: ~";
            this.labelRole.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelLogin
            // 
            this.labelLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogin.ForeColor = System.Drawing.Color.White;
            this.labelLogin.Location = new System.Drawing.Point(3, 0);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(106, 20);
            this.labelLogin.TabIndex = 0;
            this.labelLogin.Text = "Unauthorized";
            this.labelLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // customButtonAuth
            // 
            this.customButtonAuth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(189)))));
            this.customButtonAuth.Font = new System.Drawing.Font("Open Sans", 12F);
            this.customButtonAuth.ForeColor = System.Drawing.Color.White;
            this.customButtonAuth.Location = new System.Drawing.Point(554, 410);
            this.customButtonAuth.Name = "customButtonAuth";
            this.customButtonAuth.Rounding = 13;
            this.customButtonAuth.RoundingEnable = true;
            this.customButtonAuth.Size = new System.Drawing.Size(225, 40);
            this.customButtonAuth.TabIndex = 7;
            this.customButtonAuth.Text = "Log in / Register";
            this.customButtonAuth.Click += new System.EventHandler(this.CustomButtonAuth_Click);
            // 
            // customButtonTrain
            // 
            this.customButtonTrain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(189)))));
            this.customButtonTrain.Font = new System.Drawing.Font("Open Sans", 12F);
            this.customButtonTrain.ForeColor = System.Drawing.Color.White;
            this.customButtonTrain.Location = new System.Drawing.Point(554, 256);
            this.customButtonTrain.Name = "customButtonTrain";
            this.customButtonTrain.Rounding = 13;
            this.customButtonTrain.RoundingEnable = true;
            this.customButtonTrain.Size = new System.Drawing.Size(225, 40);
            this.customButtonTrain.TabIndex = 5;
            this.customButtonTrain.Text = "Обучить";
            this.customButtonTrain.Click += new System.EventHandler(this.customButtonTrain_Click);
            // 
            // customButtonInfoWindow
            // 
            this.customButtonInfoWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(189)))));
            this.customButtonInfoWindow.Font = new System.Drawing.Font("Open Sans", 12F);
            this.customButtonInfoWindow.ForeColor = System.Drawing.Color.White;
            this.customButtonInfoWindow.Location = new System.Drawing.Point(554, 206);
            this.customButtonInfoWindow.Name = "customButtonInfoWindow";
            this.customButtonInfoWindow.Rounding = 13;
            this.customButtonInfoWindow.RoundingEnable = true;
            this.customButtonInfoWindow.Size = new System.Drawing.Size(225, 40);
            this.customButtonInfoWindow.TabIndex = 4;
            this.customButtonInfoWindow.Text = "Информационное окно";
            this.customButtonInfoWindow.Click += new System.EventHandler(this.CustomButtonInfoWindow_Click);
            // 
            // customButtonDetect
            // 
            this.customButtonDetect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(189)))));
            this.customButtonDetect.Font = new System.Drawing.Font("Open Sans", 12F);
            this.customButtonDetect.ForeColor = System.Drawing.Color.White;
            this.customButtonDetect.Location = new System.Drawing.Point(554, 106);
            this.customButtonDetect.Name = "customButtonDetect";
            this.customButtonDetect.Rounding = 13;
            this.customButtonDetect.RoundingEnable = true;
            this.customButtonDetect.Size = new System.Drawing.Size(225, 40);
            this.customButtonDetect.TabIndex = 3;
            this.customButtonDetect.Text = "Обнаружить";
            this.customButtonDetect.Click += new System.EventHandler(this.customButtonDetect_Click);
            // 
            // customButtonCamera
            // 
            this.customButtonCamera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(189)))));
            this.customButtonCamera.Font = new System.Drawing.Font("Open Sans", 12F);
            this.customButtonCamera.ForeColor = System.Drawing.Color.White;
            this.customButtonCamera.Location = new System.Drawing.Point(554, 56);
            this.customButtonCamera.Name = "customButtonCamera";
            this.customButtonCamera.Rounding = 13;
            this.customButtonCamera.RoundingEnable = true;
            this.customButtonCamera.Size = new System.Drawing.Size(225, 40);
            this.customButtonCamera.TabIndex = 2;
            this.customButtonCamera.Text = "Камера";
            this.customButtonCamera.Click += new System.EventHandler(this.customButtonCamera_Click);
            // 
            // roundedPictureBox1
            // 
            this.roundedPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(87)))), ((int)(((byte)(115)))));
            this.roundedPictureBox1.BackgroundImage = global::RV_FaceRecognition.Properties.Resources.Camera_plug;
            this.roundedPictureBox1.Location = new System.Drawing.Point(20, 20);
            this.roundedPictureBox1.Name = "roundedPictureBox1";
            this.roundedPictureBox1.Rounding = 4;
            this.roundedPictureBox1.RoundingEnable = true;
            this.roundedPictureBox1.Size = new System.Drawing.Size(500, 430);
            this.roundedPictureBox1.TabIndex = 0;
            this.roundedPictureBox1.TabStop = false;
            // 
            // mainFormStyle
            // 
            this.mainFormStyle.Form = this;
            this.mainFormStyle.FormStyle = RV_FaceRecognition.Components.RVFormStyle.fStyle.UserStyle;
            // 
            // mainRoundingButtonsComponent
            // 
            this.mainRoundingButtonsComponent.Rounding = 13;
            this.mainRoundingButtonsComponent.RoundingEnable = true;
            this.mainRoundingButtonsComponent.TargetForm = this;
            // 
            // customButtonRecords
            // 
            this.customButtonRecords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(189)))));
            this.customButtonRecords.Font = new System.Drawing.Font("Open Sans", 12F);
            this.customButtonRecords.ForeColor = System.Drawing.Color.White;
            this.customButtonRecords.Location = new System.Drawing.Point(554, 306);
            this.customButtonRecords.Name = "customButtonRecords";
            this.customButtonRecords.Rounding = 13;
            this.customButtonRecords.RoundingEnable = true;
            this.customButtonRecords.Size = new System.Drawing.Size(225, 40);
            this.customButtonRecords.TabIndex = 10;
            this.customButtonRecords.Text = "История записей";
            this.customButtonRecords.Click += new System.EventHandler(this.customButtonRecords_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(112)))), ((int)(((byte)(139)))));
            this.ClientSize = new System.Drawing.Size(799, 451);
            this.Controls.Add(this.customButtonRecords);
            this.Controls.Add(this.customButtonAddImage);
            this.Controls.Add(this.roundedTableLayoutPanel);
            this.Controls.Add(this.customButtonAuth);
            this.Controls.Add(this.customButtonTrain);
            this.Controls.Add(this.customButtonInfoWindow);
            this.Controls.Add(this.customButtonDetect);
            this.Controls.Add(this.customButtonCamera);
            this.Controls.Add(this.labelActions);
            this.Controls.Add(this.roundedPictureBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(815, 490);
            this.MinimumSize = new System.Drawing.Size(815, 490);
            this.Name = "MainForm";
            this.Text = "RV Face Recognition";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.roundedTableLayoutPanel.ResumeLayout(false);
            this.roundedTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roundedPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Components.RVFormStyle mainFormStyle;
        private Components.RoundingButtonsComponent mainRoundingButtonsComponent;
        private Components.Controls.RoundedPictureBox roundedPictureBox1;
        private System.Windows.Forms.Label labelActions;
        private Components.Controls.CustomButton customButtonCamera;
        private Components.Controls.CustomButton customButtonTrain;
        private Components.Controls.CustomButton customButtonInfoWindow;
        private Components.Controls.CustomButton customButtonDetect;
        private Components.Controls.CustomButton customButtonAuth;
        private Components.Controls.RoundedTableLayoutPanel roundedTableLayoutPanel;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.Label labelLogin;
        private Components.Controls.CustomButton customButtonAddImage;
        private Components.Controls.CustomButton customButtonRecords;
    }
}

