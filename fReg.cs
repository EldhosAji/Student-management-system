using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace sms
{
    public partial class fReg : UserControl
    {
        string sqlcon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\ELDHOS AJI\source\repos\university_project-master\UP\UP\university_project\sms\sms\db.mdf"";Integrated Security=True";
        public fReg()
        {
            InitializeComponent();
        }

        private void sreg_Click(object sender, EventArgs e)
        {
            int i = 0;
            string s = "";
            if (male.Checked == true)
            {
                i = 1;
                s = "male";
            }
            else if (female.Checked == true)
            {
                i = 2;
                s = "female";
            }

            if (i == 1 || i == 2)
            {
                if (ename.Text != "Employee Name")
                {
                    if (eid.Text != "Employee ID")
                    {
                        if (enumber.Text != "Contact No.")
                        {
                            if (eemail.Text != "Employee Email")
                            {
                                if (fp.Text != "")
                                {
                                    if (dp.Text != "")
                                    {

                                        try
                                        {
                                            string d = dob.Value.ToString("yyyy-MM-dd");
                                            using (SqlConnection con = new SqlConnection(sqlcon))
                                            {
                                                con.Open();
                                                string sql = "INSERT INTO emp VALUES('" + eid.Text + "','" + ename.Text + "','" + int.Parse(enumber.Text) + "','" + s + "','" + eemail.Text + "','" + d + "','" + dp.Text + "','" + fp.Text + "')";
                                                SqlCommand cmd = new SqlCommand(sql, con);
                                                cmd.ExecuteNonQuery();
                                                SqlCommand cmd1 = new SqlCommand("INSERT INTO auth VALUES('"+eemail.Text+"','"+eid.Text+"')",con);
                                                cmd1.ExecuteNonQuery();
                                                MessageBox.Show("Successful Registration");
                                                con.Close();
                                            }
                                        }
                                        catch (SqlException E)
                                        {
                                            if (E.Number == 2627)
                                                MessageBox.Show(eid.Text + " already exist");
                                            else
                                                MessageBox.Show(E.Message);
                                        }

                                        done();

                                    }
                                    else
                                        MessageBox.Show("You should fill all details");
                                }
                                else
                                    MessageBox.Show("You should fill all details");

                            }
                            else
                                MessageBox.Show("You should fill all details");

                        }
                        else
                            MessageBox.Show("You should fill all details");
                    }
                    else
                        MessageBox.Show("You should fill all details");

                }
                else
                    MessageBox.Show("You should fill all details");
            }
            else
                MessageBox.Show("You should fill all details");
        }

        private void ename_Enter(object sender, EventArgs e)
        {
            if (ename.Text == "Employee Name")
                ename.Text = "";
        }

        private void ename_Leave(object sender, EventArgs e)
        {
            if (ename.Text == "")
                ename.Text = "Employee Name";
        }

        private void eid_Enter(object sender, EventArgs e)
        {
            if (eid.Text == "Employee ID")
                eid.Text = "";

        }

        private void eid_Leave(object sender, EventArgs e)
        {
            if (eid.Text == "")
                eid.Text = "Employee ID";

        }

        private void enumber_Enter(object sender, EventArgs e)
        {
            if (enumber.Text == "Contact No.")
                enumber.Text = "";
        }

        private void snumber_Leave(object sender, EventArgs e)
        {
            if (enumber.Text == "")
                enumber.Text = "Contact No.";
        }

        private void eemail_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void eemail_Enter(object sender, EventArgs e)
        {
            if (eemail.Text == "Employee Email")
                eemail.Text = "";
        }

        private void eemail_Leave(object sender, EventArgs e)
        {
            if (eemail.Text == "")
                eemail.Text = "Employee Email";
        }
        private void done()
        {
            //throw new NotImplementedException();
            ename.Text = "Employee Name";
            eid.Text = "Employee ID";
            enumber.Text = "Contact No.";
            male.Checked = false;
            female.Checked = false;
            eemail.Text = "Enter Email";
            //sbr.Text = "Branch";
            //ssem.Text = "Semester";
            fp.Text = "";
            dp.Text = "";
        }
    }
}
