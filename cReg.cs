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
    public partial class cReg : UserControl
    {
        string sqlcon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\ELDHOS AJI\source\repos\university_project-master\UP\UP\university_project\sms\sms\db.mdf"";Integrated Security=True";

        public cReg()
        {
            InitializeComponent();
        }

        private void cname_Enter(object sender, EventArgs e)
        {
            
            if (cname.Text == "Cource Name")
                cname.Text = "";
        }

        private void cname_Leave(object sender, EventArgs e)
        {
            if (cname.Text == "")
                cname.Text = "Cource Name";
        }

        private void cid_Enter(object sender, EventArgs e)
        {
            if (cid.Text == "Cource ID")
                cid.Text = "";
        }

        private void cid_Leave(object sender, EventArgs e)
        {
            if (cid.Text == "")
                cid.Text = "Cource ID";
        }

        private void sreg_Click(object sender, EventArgs e)
        {
            if (cname.Text != "Cource Name")
            {
                if (cid.Text != "Cource ID")
                {
                    if (dp.Text != "")
                    {
                        if (fp.Text != "")
                        {
                            using (SqlConnection con = new SqlConnection(sqlcon))
                            {
                                con.Open();
                                try
                                {
                                    string sql = "INSERT INTO cource VALUES('" + cid.Text + "','" + cname.Text + "','" + dp.Text + "','" + int.Parse(fp.Text) + "',0)";
                                    SqlCommand cmd = new SqlCommand(sql, con);
                                    cmd.ExecuteNonQuery();
                                    string c = cid.Text + "m";
                                    SqlCommand cmd1 = new SqlCommand("CREATE TABLE [dbo].[" + cid.Text + "]([studentID] VARCHAR(50) NOT NULL ,[Aclass] VARCHAR(50) NULL,dt DATE) ", con);
                                    cmd1.ExecuteNonQuery();
                                    SqlCommand cmd2 = new SqlCommand("CREATE TABLE [dbo].[" + c + "]([studentID] VARCHAR(50) NOT NULL ,[t1] INT  NULL,[t2] INT NULL,[cmp] INT NULL, [qu] INT NULL,[assi] INT NULL) ", con);
                                    cmd2.ExecuteNonQuery();
                                    MessageBox.Show("Successful Registration");
                                    cid.Text = "Cource ID";
                                    cname.Text = "Cource Name";
                                    dp.Text = "";
                                    fp.Text = "";
                                    con.Close();
                                }catch(SqlException E)
                                {

                                    if (E.Number == 2627)
                                        MessageBox.Show(cid.Text + " already exist");
                                    else
                                        MessageBox.Show(E.Message);
                                }
                            }

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
    }
}
