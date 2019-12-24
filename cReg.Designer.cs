namespace sms
{
    partial class cReg
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
            this.label2 = new System.Windows.Forms.Label();
            this.fp = new System.Windows.Forms.ComboBox();
            this.dp = new System.Windows.Forms.ComboBox();
            this.cid = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.sreg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(289, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 57;
            this.label6.Text = "Semester";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(272, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 56;
            this.label5.Text = "Department";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(190, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(203, 20);
            this.label2.TabIndex = 53;
            this.label2.Text = "COURCE REGISTRATION";
            // 
            // fp
            // 
            this.fp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.fp.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.fp.FormattingEnabled = true;
            this.fp.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.fp.Location = new System.Drawing.Point(360, 160);
            this.fp.Name = "fp";
            this.fp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.fp.Size = new System.Drawing.Size(138, 24);
            this.fp.TabIndex = 52;
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
            this.dp.Location = new System.Drawing.Point(360, 113);
            this.dp.Name = "dp";
            this.dp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dp.Size = new System.Drawing.Size(138, 24);
            this.dp.TabIndex = 51;
            // 
            // cid
            // 
            this.cid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cid.ForeColor = System.Drawing.Color.Silver;
            this.cid.HintForeColor = System.Drawing.Color.Empty;
            this.cid.HintText = "";
            this.cid.isPassword = false;
            this.cid.LineFocusedColor = System.Drawing.Color.Blue;
            this.cid.LineIdleColor = System.Drawing.Color.Gray;
            this.cid.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.cid.LineThickness = 3;
            this.cid.Location = new System.Drawing.Point(74, 146);
            this.cid.Margin = new System.Windows.Forms.Padding(4);
            this.cid.Name = "cid";
            this.cid.Size = new System.Drawing.Size(133, 30);
            this.cid.TabIndex = 48;
            this.cid.Text = "Cource ID";
            this.cid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cid.Enter += new System.EventHandler(this.cid_Enter);
            this.cid.Leave += new System.EventHandler(this.cid_Leave);
            // 
            // cname
            // 
            this.cname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cname.ForeColor = System.Drawing.Color.Silver;
            this.cname.HintForeColor = System.Drawing.Color.Empty;
            this.cname.HintText = "";
            this.cname.isPassword = false;
            this.cname.LineFocusedColor = System.Drawing.Color.Blue;
            this.cname.LineIdleColor = System.Drawing.Color.Gray;
            this.cname.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.cname.LineThickness = 3;
            this.cname.Location = new System.Drawing.Point(74, 103);
            this.cname.Margin = new System.Windows.Forms.Padding(4);
            this.cname.Name = "cname";
            this.cname.Size = new System.Drawing.Size(133, 30);
            this.cname.TabIndex = 47;
            this.cname.Text = "Cource Name";
            this.cname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cname.Enter += new System.EventHandler(this.cname_Enter);
            this.cname.Leave += new System.EventHandler(this.cname_Leave);
            // 
            // sreg
            // 
            this.sreg.BackColor = System.Drawing.Color.Snow;
            this.sreg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sreg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sreg.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.sreg.Location = new System.Drawing.Point(357, 283);
            this.sreg.Name = "sreg";
            this.sreg.Size = new System.Drawing.Size(138, 35);
            this.sreg.TabIndex = 45;
            this.sreg.Text = "Register";
            this.sreg.UseVisualStyleBackColor = false;
            this.sreg.Click += new System.EventHandler(this.sreg_Click);
            // 
            // cReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fp);
            this.Controls.Add(this.dp);
            this.Controls.Add(this.cid);
            this.Controls.Add(this.cname);
            this.Controls.Add(this.sreg);
            this.Name = "cReg";
            this.Size = new System.Drawing.Size(569, 368);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox fp;
        private System.Windows.Forms.ComboBox dp;
        private Bunifu.Framework.UI.BunifuMaterialTextbox cid;
        private Bunifu.Framework.UI.BunifuMaterialTextbox cname;
        private System.Windows.Forms.Button sreg;
    }
}
