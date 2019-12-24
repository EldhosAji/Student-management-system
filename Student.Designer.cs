namespace sms
{
    partial class Student
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sub = new System.Windows.Forms.ComboBox();
            this.Semester = new System.Windows.Forms.ComboBox();
            this.Section = new System.Windows.Forms.ComboBox();
            this.dg = new System.Windows.Forms.DataGridView();
            this.sid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tmark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.att = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(222, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 67;
            this.label2.Text = "Subject";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(3, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 66;
            this.label1.Text = "Semester";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(125, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 65;
            this.label5.Text = "Section";
            // 
            // sub
            // 
            this.sub.FormattingEnabled = true;
            this.sub.Location = new System.Drawing.Point(277, 28);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(121, 21);
            this.sub.TabIndex = 63;
            this.sub.SelectedIndexChanged += new System.EventHandler(this.sub_SelectedIndexChanged);
            // 
            // Semester
            // 
            this.Semester.FormattingEnabled = true;
            this.Semester.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.Semester.Location = new System.Drawing.Point(71, 28);
            this.Semester.Name = "Semester";
            this.Semester.Size = new System.Drawing.Size(46, 21);
            this.Semester.TabIndex = 62;
            this.Semester.SelectedIndexChanged += new System.EventHandler(this.Semester_SelectedIndexChanged);
            // 
            // Section
            // 
            this.Section.FormattingEnabled = true;
            this.Section.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            ""});
            this.Section.Location = new System.Drawing.Point(180, 27);
            this.Section.Name = "Section";
            this.Section.Size = new System.Drawing.Size(41, 21);
            this.Section.TabIndex = 61;
            // 
            // dg
            // 
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sid,
            this.sname,
            this.tmark,
            this.att,
            this.eg});
            this.dg.Location = new System.Drawing.Point(1, 57);
            this.dg.Name = "dg";
            this.dg.Size = new System.Drawing.Size(567, 284);
            this.dg.TabIndex = 60;
            // 
            // sid
            // 
            this.sid.DataPropertyName = "studentID";
            this.sid.HeaderText = "Student ID";
            this.sid.Name = "sid";
            this.sid.ReadOnly = true;
            // 
            // sname
            // 
            this.sname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sname.DataPropertyName = "studentName";
            this.sname.HeaderText = "Student Name";
            this.sname.Name = "sname";
            this.sname.ReadOnly = true;
            // 
            // tmark
            // 
            this.tmark.HeaderText = "Pre-Comprehensive";
            this.tmark.Name = "tmark";
            // 
            // att
            // 
            this.att.HeaderText = "Total Attendance";
            this.att.Name = "att";
            this.att.ReadOnly = true;
            // 
            // eg
            // 
            this.eg.HeaderText = "NE / NP /E";
            this.eg.Name = "eg";
            this.eg.ReadOnly = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(420, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 23);
            this.button1.TabIndex = 68;
            this.button1.Text = "View all students";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.Semester);
            this.Controls.Add(this.Section);
            this.Controls.Add(this.dg);
            this.Name = "Student";
            this.Size = new System.Drawing.Size(569, 368);
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox sub;
        private System.Windows.Forms.ComboBox Semester;
        private System.Windows.Forms.ComboBox Section;
        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.DataGridViewTextBoxColumn sid;
        private System.Windows.Forms.DataGridViewTextBoxColumn sname;
        private System.Windows.Forms.DataGridViewTextBoxColumn tmark;
        private System.Windows.Forms.DataGridViewTextBoxColumn att;
        private System.Windows.Forms.DataGridViewTextBoxColumn eg;
        private System.Windows.Forms.Button button1;
    }
}
