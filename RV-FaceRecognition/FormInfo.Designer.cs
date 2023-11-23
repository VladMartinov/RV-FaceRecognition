namespace RV_FaceRecognition
{
    partial class FormInfo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInfo));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDateCreate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDateUpdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTrain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customButtonAdd = new RV_FaceRecognition.Components.Controls.CustomButton();
            this.customButtonUpd = new RV_FaceRecognition.Components.Controls.CustomButton();
            this.customButtonDel = new RV_FaceRecognition.Components.Controls.CustomButton();
            this.rvFormStyle1 = new RV_FaceRecognition.Components.RVFormStyle(this.components);
            this.roundingButtonsComponent1 = new RV_FaceRecognition.Components.RoundingButtonsComponent(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(112)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(112)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnFileName,
            this.ColumnFullName,
            this.ColumnDateCreate,
            this.ColumnDateUpdate,
            this.ColumnTrain});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(112)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(189)))));
            this.dataGridView1.Location = new System.Drawing.Point(20, 20);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(112)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(112)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Size = new System.Drawing.Size(774, 389);
            this.dataGridView1.TabIndex = 3;
            // 
            // ColumnFileName
            // 
            this.ColumnFileName.HeaderText = "Наименование файла";
            this.ColumnFileName.Name = "ColumnFileName";
            this.ColumnFileName.Width = 146;
            // 
            // ColumnFullName
            // 
            this.ColumnFullName.HeaderText = "ФИО";
            this.ColumnFullName.Name = "ColumnFullName";
            this.ColumnFullName.Width = 146;
            // 
            // ColumnDateCreate
            // 
            this.ColumnDateCreate.HeaderText = "Дата создания";
            this.ColumnDateCreate.Name = "ColumnDateCreate";
            this.ColumnDateCreate.Width = 146;
            // 
            // ColumnDateUpdate
            // 
            this.ColumnDateUpdate.HeaderText = "Дата обновления";
            this.ColumnDateUpdate.Name = "ColumnDateUpdate";
            this.ColumnDateUpdate.Width = 146;
            // 
            // ColumnTrain
            // 
            this.ColumnTrain.HeaderText = "Обучение";
            this.ColumnTrain.Name = "ColumnTrain";
            this.ColumnTrain.Width = 146;
            // 
            // customButtonAdd
            // 
            this.customButtonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(189)))));
            this.customButtonAdd.Font = new System.Drawing.Font("Open Sans", 8F);
            this.customButtonAdd.ForeColor = System.Drawing.Color.White;
            this.customButtonAdd.Location = new System.Drawing.Point(474, 424);
            this.customButtonAdd.Name = "customButtonAdd";
            this.customButtonAdd.Rounding = 13;
            this.customButtonAdd.RoundingEnable = true;
            this.customButtonAdd.Size = new System.Drawing.Size(100, 25);
            this.customButtonAdd.TabIndex = 2;
            this.customButtonAdd.Text = "Добавить";
            // 
            // customButtonUpd
            // 
            this.customButtonUpd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(189)))));
            this.customButtonUpd.Font = new System.Drawing.Font("Open Sans", 8F);
            this.customButtonUpd.ForeColor = System.Drawing.Color.White;
            this.customButtonUpd.Location = new System.Drawing.Point(584, 424);
            this.customButtonUpd.Name = "customButtonUpd";
            this.customButtonUpd.Rounding = 13;
            this.customButtonUpd.RoundingEnable = true;
            this.customButtonUpd.Size = new System.Drawing.Size(100, 25);
            this.customButtonUpd.TabIndex = 1;
            this.customButtonUpd.Text = "Обновить";
            // 
            // customButtonDel
            // 
            this.customButtonDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(189)))));
            this.customButtonDel.Font = new System.Drawing.Font("Open Sans", 8F);
            this.customButtonDel.ForeColor = System.Drawing.Color.White;
            this.customButtonDel.Location = new System.Drawing.Point(694, 424);
            this.customButtonDel.Name = "customButtonDel";
            this.customButtonDel.Rounding = 13;
            this.customButtonDel.RoundingEnable = true;
            this.customButtonDel.Size = new System.Drawing.Size(100, 25);
            this.customButtonDel.TabIndex = 0;
            this.customButtonDel.Text = "Удалить";
            // 
            // rvFormStyle1
            // 
            this.rvFormStyle1.Form = this;
            this.rvFormStyle1.FormStyle = RV_FaceRecognition.Components.RVFormStyle.fStyle.UserStyle;
            // 
            // roundingButtonsComponent1
            // 
            this.roundingButtonsComponent1.Rounding = 13;
            this.roundingButtonsComponent1.RoundingEnable = true;
            this.roundingButtonsComponent1.TargetForm = this;
            // 
            // FormInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(112)))), ((int)(((byte)(139)))));
            this.ClientSize = new System.Drawing.Size(799, 451);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.customButtonAdd);
            this.Controls.Add(this.customButtonUpd);
            this.Controls.Add(this.customButtonDel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(815, 490);
            this.MinimumSize = new System.Drawing.Size(815, 490);
            this.Name = "FormInfo";
            this.Text = "RV Face Recognition";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Components.RVFormStyle rvFormStyle1;
        private Components.Controls.CustomButton customButtonAdd;
        private Components.Controls.CustomButton customButtonUpd;
        private Components.Controls.CustomButton customButtonDel;
        private Components.RoundingButtonsComponent roundingButtonsComponent1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDateCreate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDateUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTrain;
    }
}