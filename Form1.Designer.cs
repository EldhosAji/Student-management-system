namespace sms
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dbDataSet = new sms.dbDataSet();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentTableAdapter = new sms.dbDataSetTableAdapters.studentTableAdapter();
            this.studentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentGDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ssectionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sbranchDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ssemDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gnumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentIDDataGridViewTextBoxColumn,
            this.studentNameDataGridViewTextBoxColumn,
            this.studentNoDataGridViewTextBoxColumn,
            this.studentGDataGridViewTextBoxColumn,
            this.sdobDataGridViewTextBoxColumn,
            this.ssectionDataGridViewTextBoxColumn,
            this.sbranchDataGridViewTextBoxColumn,
            this.ssemDataGridViewTextBoxColumn,
            this.gnameDataGridViewTextBoxColumn,
            this.gnumberDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(924, 222);
            this.dataGridView1.TabIndex = 0;
            // 
            // dbDataSet
            // 
            this.dbDataSet.DataSetName = "dbDataSet";
            this.dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "student";
            this.studentBindingSource.DataSource = this.dbDataSet;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // studentIDDataGridViewTextBoxColumn
            // 
            this.studentIDDataGridViewTextBoxColumn.DataPropertyName = "studentID";
            this.studentIDDataGridViewTextBoxColumn.HeaderText = "studentID";
            this.studentIDDataGridViewTextBoxColumn.Name = "studentIDDataGridViewTextBoxColumn";
            // 
            // studentNameDataGridViewTextBoxColumn
            // 
            this.studentNameDataGridViewTextBoxColumn.DataPropertyName = "studentName";
            this.studentNameDataGridViewTextBoxColumn.HeaderText = "studentName";
            this.studentNameDataGridViewTextBoxColumn.Name = "studentNameDataGridViewTextBoxColumn";
            // 
            // studentNoDataGridViewTextBoxColumn
            // 
            this.studentNoDataGridViewTextBoxColumn.DataPropertyName = "studentNo";
            this.studentNoDataGridViewTextBoxColumn.HeaderText = "studentNo";
            this.studentNoDataGridViewTextBoxColumn.Name = "studentNoDataGridViewTextBoxColumn";
            // 
            // studentGDataGridViewTextBoxColumn
            // 
            this.studentGDataGridViewTextBoxColumn.DataPropertyName = "studentG";
            this.studentGDataGridViewTextBoxColumn.HeaderText = "studentG";
            this.studentGDataGridViewTextBoxColumn.Name = "studentGDataGridViewTextBoxColumn";
            // 
            // sdobDataGridViewTextBoxColumn
            // 
            this.sdobDataGridViewTextBoxColumn.DataPropertyName = "sdob";
            this.sdobDataGridViewTextBoxColumn.HeaderText = "DOB";
            this.sdobDataGridViewTextBoxColumn.Name = "sdobDataGridViewTextBoxColumn";
            // 
            // ssectionDataGridViewTextBoxColumn
            // 
            this.ssectionDataGridViewTextBoxColumn.DataPropertyName = "ssection";
            this.ssectionDataGridViewTextBoxColumn.HeaderText = "Section";
            this.ssectionDataGridViewTextBoxColumn.Name = "ssectionDataGridViewTextBoxColumn";
            // 
            // sbranchDataGridViewTextBoxColumn
            // 
            this.sbranchDataGridViewTextBoxColumn.DataPropertyName = "sbranch";
            this.sbranchDataGridViewTextBoxColumn.HeaderText = "Branch";
            this.sbranchDataGridViewTextBoxColumn.Name = "sbranchDataGridViewTextBoxColumn";
            // 
            // ssemDataGridViewTextBoxColumn
            // 
            this.ssemDataGridViewTextBoxColumn.DataPropertyName = "ssem";
            this.ssemDataGridViewTextBoxColumn.HeaderText = "Sem";
            this.ssemDataGridViewTextBoxColumn.Name = "ssemDataGridViewTextBoxColumn";
            // 
            // gnameDataGridViewTextBoxColumn
            // 
            this.gnameDataGridViewTextBoxColumn.DataPropertyName = "gname";
            this.gnameDataGridViewTextBoxColumn.HeaderText = "gname";
            this.gnameDataGridViewTextBoxColumn.Name = "gnameDataGridViewTextBoxColumn";
            // 
            // gnumberDataGridViewTextBoxColumn
            // 
            this.gnumberDataGridViewTextBoxColumn.DataPropertyName = "gnumber";
            this.gnumberDataGridViewTextBoxColumn.HeaderText = "gnumber";
            this.gnumberDataGridViewTextBoxColumn.Name = "gnumberDataGridViewTextBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 383);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private dbDataSet dbDataSet;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private dbDataSetTableAdapters.studentTableAdapter studentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentGDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ssectionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sbranchDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ssemDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gnumberDataGridViewTextBoxColumn;
    }
}