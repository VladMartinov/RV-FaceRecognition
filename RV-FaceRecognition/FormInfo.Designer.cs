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
            this.viewImagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rvfacerecognitionDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rv_facerecognitionDataSet = new RV_FaceRecognition.rv_facerecognitionDataSet();
            this.view_ImagesTableAdapter = new RV_FaceRecognition.rv_facerecognitionDataSetTableAdapters.View_ImagesTableAdapter();
            this.customButtonAdd = new RV_FaceRecognition.Components.Controls.CustomButton();
            this.customButtonUpd = new RV_FaceRecognition.Components.Controls.CustomButton();
            this.customButtonDel = new RV_FaceRecognition.Components.Controls.CustomButton();
            this.rvFormStyle1 = new RV_FaceRecognition.Components.RVFormStyle(this.components);
            this.roundingButtonsComponent1 = new RV_FaceRecognition.Components.RoundingButtonsComponent(this.components);
            this.IMAGE_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iMAGEFILEDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.iMAGENAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATECREATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dATEUPDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewImagesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rvfacerecognitionDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rv_facerecognitionDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(112)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(112)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 35;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IMAGE_ID,
            this.iMAGEFILEDataGridViewImageColumn,
            this.iMAGENAMEDataGridViewTextBoxColumn,
            this.dATECREATEDataGridViewTextBoxColumn,
            this.dATEUPDATEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.viewImagesBindingSource;
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
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(112)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidth = 25;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(112)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Size = new System.Drawing.Size(774, 389);
            this.dataGridView1.TabIndex = 3;
            // 
            // viewImagesBindingSource
            // 
            this.viewImagesBindingSource.DataMember = "View_Images";
            this.viewImagesBindingSource.DataSource = this.rvfacerecognitionDataSetBindingSource;
            // 
            // rvfacerecognitionDataSetBindingSource
            // 
            this.rvfacerecognitionDataSetBindingSource.DataSource = this.rv_facerecognitionDataSet;
            this.rvfacerecognitionDataSetBindingSource.Position = 0;
            // 
            // rv_facerecognitionDataSet
            // 
            this.rv_facerecognitionDataSet.DataSetName = "rv_facerecognitionDataSet";
            this.rv_facerecognitionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // view_ImagesTableAdapter
            // 
            this.view_ImagesTableAdapter.ClearBeforeFill = true;
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
            this.customButtonAdd.Click += new System.EventHandler(this.customButtonAdd_Click);
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
            this.customButtonUpd.Click += new System.EventHandler(this.customButtonUpd_Click);
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
            this.customButtonDel.Click += new System.EventHandler(this.customButtonDel_Click);
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
            // IMAGE_ID
            // 
            this.IMAGE_ID.DataPropertyName = "IMAGE_ID";
            this.IMAGE_ID.HeaderText = "ID";
            this.IMAGE_ID.Name = "IMAGE_ID";
            this.IMAGE_ID.ReadOnly = true;
            this.IMAGE_ID.Visible = false;
            // 
            // iMAGEFILEDataGridViewImageColumn
            // 
            this.iMAGEFILEDataGridViewImageColumn.DataPropertyName = "IMAGE_FILE";
            this.iMAGEFILEDataGridViewImageColumn.HeaderText = "Изображение";
            this.iMAGEFILEDataGridViewImageColumn.Name = "iMAGEFILEDataGridViewImageColumn";
            this.iMAGEFILEDataGridViewImageColumn.ReadOnly = true;
            this.iMAGEFILEDataGridViewImageColumn.Width = 200;
            // 
            // iMAGENAMEDataGridViewTextBoxColumn
            // 
            this.iMAGENAMEDataGridViewTextBoxColumn.DataPropertyName = "IMAGE_NAME";
            this.iMAGENAMEDataGridViewTextBoxColumn.HeaderText = "ФИО";
            this.iMAGENAMEDataGridViewTextBoxColumn.Name = "iMAGENAMEDataGridViewTextBoxColumn";
            this.iMAGENAMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.iMAGENAMEDataGridViewTextBoxColumn.Width = 220;
            // 
            // dATECREATEDataGridViewTextBoxColumn
            // 
            this.dATECREATEDataGridViewTextBoxColumn.DataPropertyName = "DATE_CREATE";
            this.dATECREATEDataGridViewTextBoxColumn.HeaderText = "Дата создания";
            this.dATECREATEDataGridViewTextBoxColumn.Name = "dATECREATEDataGridViewTextBoxColumn";
            this.dATECREATEDataGridViewTextBoxColumn.ReadOnly = true;
            this.dATECREATEDataGridViewTextBoxColumn.Width = 155;
            // 
            // dATEUPDATEDataGridViewTextBoxColumn
            // 
            this.dATEUPDATEDataGridViewTextBoxColumn.DataPropertyName = "DATE_UPDATE";
            this.dATEUPDATEDataGridViewTextBoxColumn.HeaderText = "Дата обновления";
            this.dATEUPDATEDataGridViewTextBoxColumn.Name = "dATEUPDATEDataGridViewTextBoxColumn";
            this.dATEUPDATEDataGridViewTextBoxColumn.ReadOnly = true;
            this.dATEUPDATEDataGridViewTextBoxColumn.Width = 155;
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
            this.Load += new System.EventHandler(this.FormInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewImagesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rvfacerecognitionDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rv_facerecognitionDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Components.RVFormStyle rvFormStyle1;
        private Components.Controls.CustomButton customButtonAdd;
        private Components.Controls.CustomButton customButtonUpd;
        private Components.Controls.CustomButton customButtonDel;
        private Components.RoundingButtonsComponent roundingButtonsComponent1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource rvfacerecognitionDataSetBindingSource;
        private rv_facerecognitionDataSet rv_facerecognitionDataSet;
        private System.Windows.Forms.BindingSource viewImagesBindingSource;
        private rv_facerecognitionDataSetTableAdapters.View_ImagesTableAdapter view_ImagesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn IMAGE_ID;
        private System.Windows.Forms.DataGridViewImageColumn iMAGEFILEDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iMAGENAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATECREATEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dATEUPDATEDataGridViewTextBoxColumn;
    }
}