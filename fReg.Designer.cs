namespace sms
{
    partial class fReg
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.eemail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.fp = new System.Windows.Forms.ComboBox();
            this.dp = new System.Windows.Forms.ComboBox();
            this.dob = new System.Windows.Forms.DateTimePicker();
            this.enumber = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.eid = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.ename = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.female = new System.Windows.Forms.RadioButton();
            this.male = new System.Windows.Forms.RadioButton();
            this.sreg = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gb1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(286, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 43;
            this.label6.Text = "Possition";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(269, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 42;
            this.label5.Text = "Department";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(304, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 41;
            this.label4.Text = "D O B";
            // 
            // eemail
            // 
            this.eemail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.eemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.eemail.ForeColor = System.Drawing.Color.Silver;
            this.eemail.HintForeColor = System.Drawing.Color.Empty;
            this.eemail.HintText = "";
            this.eemail.isPassword = false;
            this.eemail.LineFocusedColor = System.Drawing.Color.Blue;
            this.eemail.LineIdleColor = System.Drawing.Color.Gray;
            this.eemail.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.eemail.LineThickness = 3;
            this.eemail.Location = new System.Drawing.Point(76, 257);
            this.eemail.Margin = new System.Windows.Forms.Padding(4);
            this.eemail.Name = "eemail";
            this.eemail.Size = new System.Drawing.Size(133, 30);
            this.eemail.TabIndex = 38;
            this.eemail.Text = "Employee Email";
            this.eemail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.eemail.OnValueChanged += new System.EventHandler(this.eemail_OnValueChanged);
            this.eemail.Enter += new System.EventHandler(this.eemail_Enter);
            this.eemail.Leave += new System.EventHandler(this.eemail_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(190, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 20);
            this.label2.TabIndex = 37;
            this.label2.Text = "EMPLOYEE REGISTRATION";
            // 
            // fp
            // 
            this.fp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.fp.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.fp.FormattingEnabled = true;
            this.fp.Items.AddRange(new object[] {
            "Prof",
            "Assi.Prof"});
            this.fp.Location = new System.Drawing.Point(357, 179);
            this.fp.Name = "fp";
            this.fp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.fp.Size = new System.Drawing.Size(138, 24);
            this.fp.TabIndex = 36;
            // 
            // dp
            // 
            this.dp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.dp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dp.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.dp.FormattingEnabled = true;
            this.dp.Items.AddRange(new object[] {
            "CSE",
            "EEE",
            "PEE",
            "CIV",
            "MEC",
            "ECE"});
            this.dp.Location = new System.Drawing.Point(357, 132);
            this.dp.Name = "dp";
            this.dp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dp.Size = new System.Drawing.Size(138, 24);
            this.dp.TabIndex = 35;
            // 
            // dob
            // 
            this.dob.CalendarForeColor = System.Drawing.SystemColors.ControlDark;
            this.dob.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.dob.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dob.Location = new System.Drawing.Point(357, 84);
            this.dob.Name = "dob";
            this.dob.Size = new System.Drawing.Size(138, 23);
            this.dob.TabIndex = 34;
            // 
            // enumber
            // 
            this.enumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.enumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.enumber.ForeColor = System.Drawing.Color.Silver;
            this.enumber.HintForeColor = System.Drawing.Color.Empty;
            this.enumber.HintText = "";
            this.enumber.isPassword = false;
            this.enumber.LineFocusedColor = System.Drawing.Color.Blue;
            this.enumber.LineIdleColor = System.Drawing.Color.Gray;
            this.enumber.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.enumber.LineThickness = 3;
            this.enumber.Location = new System.Drawing.Point(74, 177);
            this.enumber.Margin = new System.Windows.Forms.Padding(4);
            this.enumber.Name = "enumber";
            this.enumber.Size = new System.Drawing.Size(133, 30);
            this.enumber.TabIndex = 33;
            this.enumber.Text = "Contact No.";
            this.enumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.enumber.Enter += new System.EventHandler(this.enumber_Enter);
            this.enumber.Leave += new System.EventHandler(this.snumber_Leave);
            // 
            // eid
            // 
            this.eid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.eid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.eid.ForeColor = System.Drawing.Color.Silver;
            this.eid.HintForeColor = System.Drawing.Color.Empty;
            this.eid.HintText = "";
            this.eid.isPassword = false;
            this.eid.LineFocusedColor = System.Drawing.Color.Blue;
            this.eid.LineIdleColor = System.Drawing.Color.Gray;
            this.eid.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.eid.LineThickness = 3;
            this.eid.Location = new System.Drawing.Point(74, 120);
            this.eid.Margin = new System.Windows.Forms.Padding(4);
            this.eid.Name = "eid";
            this.eid.Size = new System.Drawing.Size(133, 30);
            this.eid.TabIndex = 32;
            this.eid.Text = "Employee ID";
            this.eid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.eid.Enter += new System.EventHandler(this.eid_Enter);
            this.eid.Leave += new System.EventHandler(this.eid_Leave);
            // 
            // ename
            // 
            this.ename.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ename.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ename.ForeColor = System.Drawing.Color.Silver;
            this.ename.HintForeColor = System.Drawing.Color.Empty;
            this.ename.HintText = "";
            this.ename.isPassword = false;
            this.ename.LineFocusedColor = System.Drawing.Color.Blue;
            this.ename.LineIdleColor = System.Drawing.Color.Gray;
            this.ename.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.ename.LineThickness = 3;
            this.ename.Location = new System.Drawing.Point(74, 77);
            this.ename.Margin = new System.Windows.Forms.Padding(4);
            this.ename.Name = "ename";
            this.ename.Size = new System.Drawing.Size(133, 30);
            this.ename.TabIndex = 31;
            this.ename.Text = "Employee Name";
            this.ename.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ename.Enter += new System.EventHandler(this.ename_Enter);
            this.ename.Leave += new System.EventHandler(this.ename_Leave);
            // 
            // gb1
            // 
            this.gb1.Controls.Add(this.female);
            this.gb1.Controls.Add(this.male);
            this.gb1.Location = new System.Drawing.Point(134, 224);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(73, 27);
            this.gb1.TabIndex = 30;
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
            // 
            // sreg
            // 
            this.sreg.BackColor = System.Drawing.Color.Snow;
            this.sreg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sreg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sreg.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.sreg.Location = new System.Drawing.Point(357, 257);
            this.sreg.Name = "sreg";
            this.sreg.Size = new System.Drawing.Size(138, 35);
            this.sreg.TabIndex = 29;
            this.sreg.Text = "Register";
            this.sreg.UseVisualStyleBackColor = false;
            this.sreg.Click += new System.EventHandler(this.sreg_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(73, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Gender";
            // 
            // fReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.eemail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fp);
            this.Controls.Add(this.dp);
            this.Controls.Add(this.dob);
            this.Controls.Add(this.enumber);
            this.Controls.Add(this.eid);
            this.Controls.Add(this.ename);
            this.Controls.Add(this.gb1);
            this.Controls.Add(this.sreg);
            this.Controls.Add(this.label1);
            this.Name = "fReg";
            this.Size = new System.Drawing.Size(569, 368);
            this.gb1.ResumeLayout(false);
            this.gb1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox eemail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox fp;
        private System.Windows.Forms.ComboBox dp;
        private System.Windows.Forms.DateTimePicker dob;
        private Bunifu.Framework.UI.BunifuMaterialTextbox enumber;
        private Bunifu.Framework.UI.BunifuMaterialTextbox eid;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ename;
        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.RadioButton female;
        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.Button sreg;
        private System.Windows.Forms.Label label1;
    }
}
