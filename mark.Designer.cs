namespace sms
{
    partial class mark
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
            this.dt = new System.Windows.Forms.DateTimePicker();
            this.sub = new System.Windows.Forms.ComboBox();
            this.sv = new System.Windows.Forms.Button();
            this.Semester = new System.Windows.Forms.ComboBox();
            this.Section = new System.Windows.Forms.ComboBox();
            this.dg = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.sid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.t2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.com = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.q = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dg)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(222, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 68;
            this.label2.Text = "Subject";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(3, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 67;
            this.label1.Text = "Semester";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(125, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 66;
            this.label5.Text = "Section";
            // 
            // dt
            // 
            this.dt.Location = new System.Drawing.Point(438, 11);
            this.dt.Name = "dt";
            this.dt.Size = new System.Drawing.Size(128, 20);
            this.dt.TabIndex = 65;
            // 
            // sub
            // 
            this.sub.FormattingEnabled = true;
            this.sub.Location = new System.Drawing.Point(277, 12);
            this.sub.Name = "sub";
            this.sub.Size = new System.Drawing.Size(121, 21);
            this.sub.TabIndex = 64;
            this.sub.SelectedIndexChanged += new System.EventHandler(this.sub_SelectedIndexChanged);
            // 
            // sv
            // 
            this.sv.Location = new System.Drawing.Point(480, 334);
            this.sv.Name = "sv";
            this.sv.Size = new System.Drawing.Size(75, 23);
            this.sv.TabIndex = 63;
            this.sv.Text = "Save";
            this.sv.UseVisualStyleBackColor = true;
            this.sv.Click += new System.EventHandler(this.sv_Click);
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
            this.Semester.Location = new System.Drawing.Point(71, 12);
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
            this.Section.Location = new System.Drawing.Point(180, 11);
            this.Section.Name = "Section";
            this.Section.Size = new System.Drawing.Size(41, 21);
            this.Section.TabIndex = 61;
            this.Section.SelectedIndexChanged += new System.EventHandler(this.Section_SelectedIndexChanged);
            // 
            // dg
            // 
            this.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sid,
            this.sname,
            this.t1,
            this.t2,
            this.com,
            this.q,
            this.assi});
            this.dg.Location = new System.Drawing.Point(1, 41);
            this.dg.Name = "dg";
            this.dg.Size = new System.Drawing.Size(567, 284);
            this.dg.TabIndex = 60;
            this.dg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(3, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 69;
            this.label3.Text = "Test1-40";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(74, 328);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 70;
            this.label4.Text = "Test2-40";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(156, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 17);
            this.label6.TabIndex = 71;
            this.label6.Text = "End Term -80";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(250, 328);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 17);
            this.label7.TabIndex = 72;
            this.label7.Text = "Assignment -20";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(351, 328);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 17);
            this.label8.TabIndex = 73;
            this.label8.Text = "Quiz-20";
            // 
            // sid
            // 
            this.sid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sid.DataPropertyName = "studentID";
            this.sid.FillWeight = 195.4315F;
            this.sid.HeaderText = "Student ID";
            this.sid.Name = "sid";
            this.sid.ReadOnly = true;
            // 
            // sname
            // 
            this.sname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sname.DataPropertyName = "studentName";
            this.sname.FillWeight = 227.4111F;
            this.sname.HeaderText = "Student Name";
            this.sname.Name = "sname";
            this.sname.ReadOnly = true;
            // 
            // t1
            // 
            this.t1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.t1.FillWeight = 55.43148F;
            this.t1.HeaderText = "Test 1";
            this.t1.Name = "t1";
            // 
            // t2
            // 
            this.t2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.t2.FillWeight = 55.43148F;
            this.t2.HeaderText = "Test 2";
            this.t2.Name = "t2";
            // 
            // com
            // 
            this.com.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.com.HeaderText = "Com";
            this.com.Name = "com";
            // 
            // q
            // 
            this.q.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.q.FillWeight = 55.43148F;
            this.q.HeaderText = "Quiz";
            this.q.Name = "q";
            // 
            // assi
            // 
            this.assi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.assi.FillWeight = 55.43148F;
            this.assi.HeaderText = "Assignment";
            this.assi.Name = "assi";
            // 
            // mark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dt);
            this.Controls.Add(this.sub);
            this.Controls.Add(this.sv);
            this.Controls.Add(this.Semester);
            this.Controls.Add(this.Section);
            this.Controls.Add(this.dg);
            this.Name = "mark";
            this.Size = new System.Drawing.Size(569, 368);
            ((System.ComponentModel.ISupportInitialize)(this.dg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dt;
        private System.Windows.Forms.ComboBox sub;
        private System.Windows.Forms.Button sv;
        private System.Windows.Forms.ComboBox Semester;
        private System.Windows.Forms.ComboBox Section;
        private System.Windows.Forms.DataGridView dg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn sid;
        private System.Windows.Forms.DataGridViewTextBoxColumn sname;
        private System.Windows.Forms.DataGridViewTextBoxColumn t1;
        private System.Windows.Forms.DataGridViewTextBoxColumn t2;
        private System.Windows.Forms.DataGridViewTextBoxColumn com;
        private System.Windows.Forms.DataGridViewTextBoxColumn q;
        private System.Windows.Forms.DataGridViewTextBoxColumn assi;
    }
}
