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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        private bool mouseDown;
        private Point lastLocation;
        #region panel drag

        private void header_Paint(object sender, PaintEventArgs e)
        {

        }

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


        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {
            
            
        }

        private void faade_TransitionEnd(object sender, EventArgs e)
        {
            
        }

        private void close_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            if (userbox.Text == "admin" && passbox.Text == "admin")
            {
                material_test m = new material_test();
                m.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Invalid username or password");
        }
    }
}
