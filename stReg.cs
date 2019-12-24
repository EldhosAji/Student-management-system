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
    public partial class stReg : UserControl
    {
        string sqlcon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\ELDHOS AJI\source\repos\university_project-master\UP\UP\university_project\sms\sms\db.mdf"";Integrated Security=True";
        public stReg()
        {
            InitializeComponent();
        }

        private void stReg_Load(object sender, EventArgs e)
        {

        }

        private void sname_OnValueChanged(object sender, EventArgs e)
        {
            if (sname.Text == "Student Name")
                sname.Text = "";
        }

        public void snameselect()
        {
           
        }

        private void snameleave(object sender, EventArgs e)
        {
            if (sname.Text == "")
                sname.Text = "Student Name";
        }

        private void sname_Enter(object sender, EventArgs e)
        {
            if (sname.Text == "Student Name")
                sname.Text = "";
        }

        private void bunifuMaterialTextbox1_Enter(object sender, EventArgs e)
        {
            if (sid.Text == "Student ID")
                sid.Text = "";
        }

        private void sid_Leave(object sender, EventArgs e)
        {
            if (sid.Text == "")
                sid.Text = "Student ID";
        }

        private void snumber_Enter(object sender, EventArgs e)
        {
            if (snumber.Text == "Contact No.")
                snumber.Text = "";
        }

        private void snumber_Leave(object sender, EventArgs e)
        {
            if (snumber.Text == "")
                snumber.Text = "Contact No.";
        }

        private void bunifuMaterialTextbox2_Enter(object sender, EventArgs e)
        {
            if (gname.Text == "Gardian Name")
                gname.Text = "";
        }

        private void gname_Leave(object sender, EventArgs e)
        {
            if (gname.Text == "")
                gname.Text = "Gardian Name";
        }

        private void gnumber_Enter(object sender, EventArgs e)
        {
            if (gnumber.Text == "Gardian No.")
                gnumber.Text = "";
        }

        private void gnumber_Leave(object sender, EventArgs e)
        {
            if (gnumber.Text == "")
                gnumber.Text = "Gardian No.";
        }

        private void sreg_Click(object sender, EventArgs e)
        {
            int i=0;
            string s="";
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
                if (sname.Text != "Student Name")
                {
                    if (sid.Text != "Student ID")
                    {
                        if (snumber.Text != "Contact No.")
                        {
                            if (gname.Text != "Gardian Name")
                            {
                                if (gnumber.Text != "Gardian No.")
                                {
                                    if (ssec.Text != "Section")
                                    {
                                        if (ssem.Text != "Semester")
                                        {
                                            if (sbr.Text != "Branch")
                                            {
                                               
                                                try
                                                {
                                                    string d = dob.Value.ToString("yyyy-MM-dd");
                                                    using (SqlConnection con = new SqlConnection(sqlcon))
                                                    {
                                                        con.Open();
                                                        string sql = "INSERT INTO student VALUES('" + sid.Text + "','" + sname.Text + "','" + int.Parse(snumber.Text) + "','" + s + "','" + d + "','" + int.Parse(ssec.Text) + "','" + sbr.Text + "','" + int.Parse(ssem.Text) + "','" + gname.Text + "','" + int.Parse(gnumber.Text) + "')";
                                                        SqlCommand cmd = new SqlCommand(sql, con);
                                                        cmd.ExecuteNonQuery();
                                                        MessageBox.Show("Successful Registration");
                                                        con.Close();
                                                    }
                                                }
                                                catch(SqlException E)
                                                {
                                                    if (E.Number == 2627)
                                                        MessageBox.Show(sid.Text + " already exist");
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
                else
                    MessageBox.Show("You should fill all details");
            }
            else
                MessageBox.Show("You should fill all details");
        }

        private void done()
        {
            //throw new NotImplementedException();
            sname.Text = "Student Name";
            sid.Text = "Student ID";
            snumber.Text = "Contact No.";
            male.Checked = false;
            female.Checked = false;
            ssec.Text = "Section";
            sbr.Text = "Branch";
            ssem.Text = "Semester";
            gname.Text = "Gardian Name";
            gnumber.Text = "Gardian No.";
        }

        private void male_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
