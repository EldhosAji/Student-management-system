namespace sms
{
    partial class stReg
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
            this.label1 = new System.Windows.Forms.Label();
            this.ssec = new System.Windows.Forms.ComboBox();
            this.sreg = new System.Windows.Forms.Button();
            this.male = new System.Windows.Forms.RadioButton();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.female = new System.Windows.Forms.RadioButton();
            this.sname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.sid = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.snumber = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.dob = new System.Windows.Forms.DateTimePicker();
            this.ssem = new System.Windows.Forms.ComboBox();
            this.sbr = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gnumber = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.gname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gb1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(57, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gender";
            // 
            // ssec
            // 
            this.ssec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ssec.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ssec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ssec.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.ssec.FormattingEnabled = true;
            this.ssec.Items.AddRange(new object[] {
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
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.ssec.Location = new System.Drawing.Point(341, 84);
            this.ssec.Name = "ssec";
            this.ssec.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ssec.Size = new System.Drawing.Size(138, 24);
            this.ssec.TabIndex = 2;
            // 
            // sreg
            // 
            this.sreg.BackColor = System.Drawing.Color.Snow;
            this.sreg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sreg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sreg.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.sreg.Location = new System.Drawing.Point(341, 305);
            this.sreg.Name = "sreg";
            this.sreg.Size = new System.Drawing.Size(138, 35);
            this.sreg.TabIndex = 3;
            this.sreg.Text = "Register";
            this.sreg.UseVisualStyleBackColor = false;
            this.sreg.Click += new System.EventHandler(this.sreg_Click);
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.BackColor = System.Drawing.Color.Transparent;
            this.male.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.male.Location = new System.Drawing.Point(5, 8);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(34, 17);
            this.male.TabIndex = 4;
            this.male.TabStop = true;
            this.male.Text = "M";
            this.male.UseVisualStyleBackColor = false;
            this.male.CheckedChanged += new System.EventHandler(this.male_CheckedChanged);
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.female);
            this.gb1.Controls.Add(this.male);
            this.gb1.Location = new System.Drawing.Point(118, 222);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(73, 27);
            this.gb1.TabIndex = 5;
            this.gb1.TabStop = false;
            // 
            // female
            // 
            this.female.AutoSize = true;
            this.female.BackColor = System.Drawing.Color.Transparent;
            this.female.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.female.Location = new System.Drawing.Point(39, 8);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(31, 17);
            this.female.TabIndex = 6;
            this.female.TabStop = true;
            this.female.Text = "F";
            this.female.UseVisualStyleBackColor = false;
            // 
            // sname
            // 
            this.sname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.sname.ForeColor = System.Drawing.Color.Silver;
            this.sname.HintForeColor = System.Drawing.Color.Empty;
            this.sname.HintText = "";
            this.sname.isPassword = false;
            this.sname.LineFocusedColor = System.Drawing.Color.Blue;
            this.sname.LineIdleColor = System.Drawing.Color.Gray;
            this.sname.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.sname.LineThickness = 3;
            this.sname.Location = new System.Drawing.Point(58, 75);
            this.sname.Margin = new System.Windows.Forms.Padding(4);
            this.sname.Name = "sname";
            this.sname.Size = new System.Drawing.Size(133, 30);
            this.sname.TabIndex = 14;
            this.sname.Text = "Student Name";
            this.sname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sname.OnValueChanged += new System.EventHandler(this.sname_OnValueChanged);
            this.sname.Enter += new System.EventHandler(this.sname_Enter);
            this.sname.Leave += new System.EventHandler(this.snameleave);
            // 
            // sid
            // 
            this.sid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.sid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.sid.ForeColor = System.Drawing.Color.Silver;
            this.sid.HintForeColor = System.Drawing.Color.Empty;
            this.sid.HintText = "";
            this.sid.isPassword = false;
            this.sid.LineFocusedColor = System.Drawing.Color.Blue;
            this.sid.LineIdleColor = System.Drawing.Color.Gray;
            this.sid.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.sid.LineThickness = 3;
            this.sid.Location = new System.Drawing.Point(58, 118);
            this.sid.Margin = new System.Windows.Forms.Padding(4);
            this.sid.Name = "sid";
            this.sid.Size = new System.Drawing.Size(133, 30);
            this.sid.TabIndex = 15;
            this.sid.Text = "Student ID";
            this.sid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sid.Enter += new System.EventHandler(this.bunifuMaterialTextbox1_Enter);
            this.sid.Leave += new System.EventHandler(this.sid_Leave);
            // 
            // snumber
            // 
            this.snumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.snumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.snumber.ForeColor = System.Drawing.Color.Silver;
            this.snumber.HintForeColor = System.Drawing.Color.Empty;
            this.snumber.HintText = "";
            this.snumber.isPassword = false;
            this.snumber.LineFocusedColor = System.Drawing.Color.Blue;
            this.snumber.LineIdleColor = System.Drawing.Color.Gray;
            this.snumber.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.snumber.LineThickness = 3;
            this.snumber.Location = new System.Drawing.Point(58, 175);
            this.snumber.Margin = new System.Windows.Forms.Padding(4);
            this.snumber.Name = "snumber";
            this.snumber.Size = new System.Drawing.Size(133, 30);
            this.snumber.TabIndex = 16;
            this.snumber.Text = "Contact No.";
            this.snumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.snumber.Enter += new System.EventHandler(this.snumber_Enter);
            this.snumber.Leave += new System.EventHandler(this.snumber_Leave);
            // 
            // dob
            // 
            this.dob.CalendarForeColor = System.Drawing.SystemColors.ControlDark;
            this.dob.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.dob.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dob.Location = new System.Drawing.Point(341, 130);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(138, 23);
            this.dob.TabIndex = 17;
            // 
            // ssem
            // 
            this.ssem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ssem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ssem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ssem.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.ssem.FormattingEnabled = true;
            this.ssem.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.ssem.Location = new System.Drawing.Point(341, 178);
            this.ssem.Name = "ssem";
            this.ssem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ssem.Size = new System.Drawing.Size(138, 24);
            this.ssem.TabIndex = 18;
            // 
            // sbr
            // 
            this.sbr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sbr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sbr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.sbr.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.sbr.FormattingEnabled = true;
            this.sbr.Items.AddRange(new object[] {
            "CSE",
            "PEE",
            "CIV",
            "MEC",
            "EEE",
            "ECE"});
            this.sbr.Location = new System.Drawing.Point(341, 225);
            this.sbr.Name = "sbr";
            this.sbr.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.sbr.Size = new System.Drawing.Size(138, 24);
            this.sbr.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(174, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "STUDENT REGISTRATION";
            // 
            // gnumber
            // 
            this.gnumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.gnumber.ForeColor = System.Drawing.Color.Silver;
            this.gnumber.HintForeColor = System.Drawing.Color.Empty;
            this.gnumber.HintText = "";
            this.gnumber.isPassword = false;
            this.gnumber.LineFocusedColor = System.Drawing.Color.Blue;
            this.gnumber.LineIdleColor = System.Drawing.Color.Gray;
            this.gnumber.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.gnumber.LineThickness = 3;
            this.gnumber.Location = new System.Drawing.Point(60, 312);
            this.gnumber.Margin = new System.Windows.Forms.Padding(4);
            this.gnumber.Name = "gnumber";
            this.gnumber.Size = new System.Drawing.Size(133, 30);
            this.gnumber.TabIndex = 22;
            this.gnumber.Text = "Gardian No.";
            this.gnumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gnumber.Enter += new System.EventHandler(this.gnumber_Enter);
            this.gnumber.Leave += new System.EventHandler(this.gnumber_Leave);
            // 
            // gname
            // 
            this.gname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.gname.ForeColor = System.Drawing.Color.Silver;
            this.gname.HintForeColor = System.Drawing.Color.Empty;
            this.gname.HintText = "";
            this.gname.isPassword = false;
            this.gname.LineFocusedColor = System.Drawing.Color.Blue;
            this.gname.LineIdleColor = System.Drawing.Color.Gray;
            this.gname.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.gname.LineThickness = 3;
            this.gname.Location = new System.Drawing.Point(60, 255);
            this.gname.Margin = new System.Windows.Forms.Padding(4);
            this.gname.Name = "gname";
            this.gname.Size = new System.Drawing.Size(133, 30);
            this.gname.TabIndex = 21;
            this.gname.Text = "Gardian Name";
            this.gname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gname.Enter += new System.EventHandler(this.bunifuMaterialTextbox2_Enter);
            this.gname.Leave += new System.EventHandler(this.gname_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(279, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Section";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(288, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "D O B";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(266, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "Semester";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(282, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = "Branch";
            // 
            // stReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gnumber);
            this.Controls.Add(this.gname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sbr);
            this.Controls.Add(this.ssem);
            this.Controls.Add(this.dob);
            this.Controls.Add(this.snumber);
            this.Controls.Add(this.sid);
            this.Controls.Add(this.sname);
            this.Controls.Add(this.gb1);
            this.Controls.Add(this.sreg);
            this.Controls.Add(this.ssec);
            this.Controls.Add(this.label1);
            this.Name = "stReg";
            this.Size = new System.Drawing.Size(569, 368);
            this.Load += new System.EventHandler(this.stReg_Load);
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ssec;
        private System.Windows.Forms.Button sreg;
        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.RadioButton female;
        private Bunifu.Framework.UI.BunifuMaterialTextbox sname;
        private Bunifu.Framework.UI.BunifuMaterialTextbox sid;
        private Bunifu.Framework.UI.BunifuMaterialTextbox snumber;
        private System.Windows.Forms.DateTimePicker dob;
        private System.Windows.Forms.ComboBox ssem;
        private System.Windows.Forms.ComboBox sbr;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox gnumber;
        private Bunifu.Framework.UI.BunifuMaterialTextbox gname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}
