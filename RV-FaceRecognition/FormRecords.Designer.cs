namespace RV_FaceRecognition
{
    partial class FormRecords
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRecords));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.viewRecordsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rv_facerecognitionDataSet = new RV_FaceRecognition.rv_facerecognitionDataSet();
            this.rvFormStyle1 = new RV_FaceRecognition.Components.RVFormStyle(this.components);
            this.view_RecordsTableAdapter = new RV_FaceRecognition.rv_facerecognitionDataSetTableAdapters.View_RecordsTableAdapter();
            this.customButtonStatistic = new RV_FaceRecognition.Components.Controls.CustomButton();
            this.rECORDIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uSERLOGINDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aCTIONNAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rECORDDESCRIPTIONDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rECORDDATEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewRecordsBindingSource)).BeginInit();
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
            this.rECORDIDDataGridViewTextBoxColumn,
            this.uSERLOGINDataGridViewTextBoxColumn,
            this.aCTIONNAMEDataGridViewTextBoxColumn,
            this.rECORDDESCRIPTIONDataGridViewTextBoxColumn,
            this.rECORDDATEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.viewRecordsBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(112)))), ((int)(((byte)(139)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(189)))));
            this.dataGridView1.Location = new System.Drawing.Point(13, 11);
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
            this.dataGridView1.Size = new System.Drawing.Size(774, 399);
            this.dataGridView1.TabIndex = 7;
            // 
            // viewRecordsBindingSource
            // 
            this.viewRecordsBindingSource.DataMember = "View_Records";
            this.viewRecordsBindingSource.DataSource = this.rv_facerecognitionDataSet;
            // 
            // rv_facerecognitionDataSet
            // 
            this.rv_facerecognitionDataSet.DataSetName = "rv_facerecognitionDataSet";
            this.rv_facerecognitionDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rvFormStyle1
            // 
            this.rvFormStyle1.Form = this;
            this.rvFormStyle1.FormStyle = RV_FaceRecognition.Components.RVFormStyle.fStyle.UserStyle;
            // 
            // view_RecordsTableAdapter
            // 
            this.view_RecordsTableAdapter.ClearBeforeFill = true;
            // 
            // customButtonStatistic
            // 
            this.customButtonStatistic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(162)))), ((int)(((byte)(189)))));
            this.customButtonStatistic.Font = new System.Drawing.Font("Open Sans", 8F);
            this.customButtonStatistic.ForeColor = System.Drawing.Color.White;
            this.customButtonStatistic.Location = new System.Drawing.Point(619, 420);
            this.customButtonStatistic.Name = "customButtonStatistic";
            this.customButtonStatistic.Rounding = 13;
            this.customButtonStatistic.RoundingEnable = true;
            this.customButtonStatistic.Size = new System.Drawing.Size(168, 25);
            this.customButtonStatistic.TabIndex = 8;
            this.customButtonStatistic.Text = "Просмотреть статистику";
            this.customButtonStatistic.Click += new System.EventHandler(this.customButtonStatistic_Click);
            // 
            // rECORDIDDataGridViewTextBoxColumn
            // 
            this.rECORDIDDataGridViewTextBoxColumn.DataPropertyName = "RECORD_ID";
            this.rECORDIDDataGridViewTextBoxColumn.HeaderText = "RECORD_ID";
            this.rECORDIDDataGridViewTextBoxColumn.Name = "rECORDIDDataGridViewTextBoxColumn";
            this.rECORDIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.rECORDIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // uSERLOGINDataGridViewTextBoxColumn
            // 
            this.uSERLOGINDataGridViewTextBoxColumn.DataPropertyName = "USER_LOGIN";
            this.uSERLOGINDataGridViewTextBoxColumn.HeaderText = "Пользователь";
            this.uSERLOGINDataGridViewTextBoxColumn.Name = "uSERLOGINDataGridViewTextBoxColumn";
            this.uSERLOGINDataGridViewTextBoxColumn.ReadOnly = true;
            this.uSERLOGINDataGridViewTextBoxColumn.Width = 140;
            // 
            // aCTIONNAMEDataGridViewTextBoxColumn
            // 
            this.aCTIONNAMEDataGridViewTextBoxColumn.DataPropertyName = "ACTION_NAME";
            this.aCTIONNAMEDataGridViewTextBoxColumn.HeaderText = "Действие";
            this.aCTIONNAMEDataGridViewTextBoxColumn.Name = "aCTIONNAMEDataGridViewTextBoxColumn";
            this.aCTIONNAMEDataGridViewTextBoxColumn.ReadOnly = true;
            this.aCTIONNAMEDataGridViewTextBoxColumn.Width = 200;
            // 
            // rECORDDESCRIPTIONDataGridViewTextBoxColumn
            // 
            this.rECORDDESCRIPTIONDataGridViewTextBoxColumn.DataPropertyName = "RECORD_DESCRIPTION";
            this.rECORDDESCRIPTIONDataGridViewTextBoxColumn.HeaderText = "Описание";
            this.rECORDDESCRIPTIONDataGridViewTextBoxColumn.Name = "rECORDDESCRIPTIONDataGridViewTextBoxColumn";
            this.rECORDDESCRIPTIONDataGridViewTextBoxColumn.ReadOnly = true;
            this.rECORDDESCRIPTIONDataGridViewTextBoxColumn.Width = 270;
            // 
            // rECORDDATEDataGridViewTextBoxColumn
            // 
            this.rECORDDATEDataGridViewTextBoxColumn.DataPropertyName = "RECORD_DATE";
            this.rECORDDATEDataGridViewTextBoxColumn.HeaderText = "Дата совершения";
            this.rECORDDATEDataGridViewTextBoxColumn.Name = "rECORDDATEDataGridViewTextBoxColumn";
            this.rECORDDATEDataGridViewTextBoxColumn.ReadOnly = true;
            this.rECORDDATEDataGridViewTextBoxColumn.Width = 120;
            // 
            // FormRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(112)))), ((int)(((byte)(139)))));
            this.ClientSize = new System.Drawing.Size(792, 447);
            this.Controls.Add(this.customButtonStatistic);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(808, 486);
            this.MinimumSize = new System.Drawing.Size(808, 486);
            this.Name = "FormRecords";
            this.Text = "RV Face Recognition";
            this.Load += new System.EventHandler(this.FormRecords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewRecordsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rv_facerecognitionDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Components.RVFormStyle rvFormStyle1;
        private rv_facerecognitionDataSet rv_facerecognitionDataSet;
        private System.Windows.Forms.BindingSource viewRecordsBindingSource;
        private rv_facerecognitionDataSetTableAdapters.View_RecordsTableAdapter view_RecordsTableAdapter;
        private Components.Controls.CustomButton customButtonStatistic;
        private System.Windows.Forms.DataGridViewTextBoxColumn rECORDIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn uSERLOGINDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aCTIONNAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rECORDDESCRIPTIONDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rECORDDATEDataGridViewTextBoxColumn;
    }
}