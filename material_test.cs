using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sms
{
    public partial class material_test : Form
    {
        public material_test()
        {
            
            InitializeComponent();
        }
        private bool mouseDown;
        private Point lastLocation;
        #region panel drag

        private void panelHeader_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void panelHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point((this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);
                this.Update();
            }
        }

        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;

        }
        #endregion

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void menu_Click(object sender, EventArgs e)
        {
            if (drawer.Visible) drawhide.HideSync(drawer);
            else drawshow.ShowSync(drawer);
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            stReg2.Visible = false;
            cReg2.Visible = false;
            fReg2.Visible = true;
            mark1.Visible = false;
            atten1.Visible = false;
            student1.Visible = false;

        }

        private void belowheader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void stReg1_Load(object sender, EventArgs e)
        {

        }

        private void content_Paint(object sender, PaintEventArgs e)
        {

        }

        private void header_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            stReg2.Visible = true;
            cReg2.Visible = false;
            fReg2.Visible = false;
            atten1.Visible = false;
            mark1.Visible = false;
            student1.Visible = false;
        }

        private void material_test_Load(object sender, EventArgs e)
        {
            stReg2.Visible = false;
            cReg2.Visible = false;
            fReg2.Visible = false;
            mark1.Visible = false;
            atten1.Visible = false;
            student1.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            stReg2.Visible = false;
            cReg2.Visible = true;
            fReg2.Visible = false;
            student1.Visible = false;
            atten1.Visible = false;
            mark1.Visible = false;
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            stReg2.Visible = false;
            cReg2.Visible = false;
            fReg2.Visible = false;
            atten1.Visible = true ;
            student1.Visible = false;
            mark1.Visible = false;
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            stReg2.Visible = false;
            cReg2.Visible = false;
            fReg2.Visible = false;
            atten1.Visible = false;
            mark1.Visible = true;
            student1.Visible = false;
        }

        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            stReg2.Visible = false;
            cReg2.Visible = false;
            fReg2.Visible = false;
            atten1.Visible = false;
            mark1.Visible = false;
            student1.Visible = true;
        }
    }
}
