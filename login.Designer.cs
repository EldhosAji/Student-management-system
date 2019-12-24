namespace sms
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.header = new System.Windows.Forms.Panel();
            this.close = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.userbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.passbox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.loginbutton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close)).BeginInit();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.BackColor = System.Drawing.SystemColors.HotTrack;
            this.header.Controls.Add(this.close);
            this.header.Dock = System.Windows.Forms.DockStyle.Top;
            this.header.Location = new System.Drawing.Point(0, 0);
            this.header.Margin = new System.Windows.Forms.Padding(2);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(421, 179);
            this.header.TabIndex = 6;
            this.header.Paint += new System.Windows.Forms.PaintEventHandler(this.header_Paint);
            this.header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseDown);
            this.header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseMove);
            this.header.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseUp);
            // 
            // close
            // 
            this.close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.Image = ((System.Drawing.Image)(resources.GetObject("close.Image")));
            this.close.ImageActive = null;
            this.close.Location = new System.Drawing.Point(396, 2);
            this.close.Margin = new System.Windows.Forms.Padding(2);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(22, 24);
            this.close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close.TabIndex = 2;
            this.close.TabStop = false;
            this.close.Zoom = 10;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(66, 379);
            this.bunifuCustomLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(92, 25);
            this.bunifuCustomLabel2.TabIndex = 10;
            this.bunifuCustomLabel2.Text = "Password";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Yu Gothic UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(66, 294);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(105, 25);
            this.bunifuCustomLabel1.TabIndex = 11;
            this.bunifuCustomLabel1.Text = "User Name";
            // 
            // userbox
            // 
            this.userbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.userbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.userbox.HintForeColor = System.Drawing.Color.Empty;
            this.userbox.HintText = "";
            this.userbox.isPassword = false;
            this.userbox.LineFocusedColor = System.Drawing.Color.Blue;
            this.userbox.LineIdleColor = System.Drawing.Color.Gray;
            this.userbox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.userbox.LineThickness = 3;
            this.userbox.Location = new System.Drawing.Point(70, 318);
            this.userbox.Margin = new System.Windows.Forms.Padding(4);
            this.userbox.Name = "userbox";
            this.userbox.Size = new System.Drawing.Size(278, 36);
            this.userbox.TabIndex = 13;
            this.userbox.Text = "admin";
            this.userbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // passbox
            // 
            this.passbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.passbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.passbox.HintForeColor = System.Drawing.Color.Empty;
            this.passbox.HintText = "";
            this.passbox.isPassword = true;
            this.passbox.LineFocusedColor = System.Drawing.Color.Blue;
            this.passbox.LineIdleColor = System.Drawing.Color.Gray;
            this.passbox.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.passbox.LineThickness = 3;
            this.passbox.Location = new System.Drawing.Point(70, 408);
            this.passbox.Margin = new System.Windows.Forms.Padding(4);
            this.passbox.Name = "passbox";
            this.passbox.Size = new System.Drawing.Size(278, 36);
            this.passbox.TabIndex = 13;
            this.passbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // loginbutton
            // 
            this.loginbutton.ActiveBorderThickness = 1;
            this.loginbutton.ActiveCornerRadius = 20;
            this.loginbutton.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.loginbutton.ActiveForecolor = System.Drawing.Color.White;
            this.loginbutton.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.loginbutton.BackColor = System.Drawing.Color.White;
            this.loginbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginbutton.BackgroundImage")));
            this.loginbutton.ButtonText = "Login";
            this.loginbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbutton.ForeColor = System.Drawing.Color.SeaGreen;
            this.loginbutton.IdleBorderThickness = 1;
            this.loginbutton.IdleCornerRadius = 20;
            this.loginbutton.IdleFillColor = System.Drawing.Color.White;
            this.loginbutton.IdleForecolor = System.Drawing.SystemColors.HotTrack;
            this.loginbutton.IdleLineColor = System.Drawing.SystemColors.HotTrack;
            this.loginbutton.Location = new System.Drawing.Point(122, 470);
            this.loginbutton.Margin = new System.Windows.Forms.Padding(4);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(151, 46);
            this.loginbutton.TabIndex = 14;
            this.loginbutton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(421, 601);
            this.Controls.Add(this.loginbutton);
            this.Controls.Add(this.passbox);
            this.Controls.Add(this.userbox);
            this.Controls.Add(this.header);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "login";
            this.Text = "login";
            this.header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.close)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel header;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox userbox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox passbox;
        private Bunifu.Framework.UI.BunifuImageButton close;
        private Bunifu.Framework.UI.BunifuThinButton2 loginbutton;
    }
}