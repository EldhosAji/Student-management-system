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
    public partial class atten : UserControl
    {
        
        string p;
        int i;
        int tp;
        int n;
        string pid;
        string sqlcon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\ELDHOS AJI\source\repos\university_project-master\UP\UP\university_project\sms\sms\db.mdf"";Integrated Security=True";
        public atten()
        {
            InitializeComponent();
        }

        private void atten_Load(object sender, EventArgs e)
        {
           
            
        }

        private void Section_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(sqlcon))
            {
                n = 0;
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT studentID,studentName FROM student WHERE ssection='" + Section.Text + "' AND ssem='"+Semester.Text+"'", con);
                using (SqlDataReader d=cmd.ExecuteReader())
                {
                    while(d.Read())
                    {
                        i++;
                        n = dg.Rows.Add();
                        dg.Rows[n].Cells[0].Value = d["studentID"].ToString();
                        dg.Rows[n].Cells[1].Value = d["studentName"].ToString();
                        dg.Rows[n].Cells[2].Value = "Present";

                    }
                }
                con.Close();
              //  SqlDataAdapter sd = new SqlDataAdapter("SELECT studentID,studentName FROM student WHERE ssection='" + Section.Text + "'", con);
              //  DataTable dt = new DataTable();
               // sd.Fill(dt);
               // sid.dis = "";
                
            }
        }

        private void sv_Click(object sender, EventArgs e)
        {
            string d = dt.Value.ToString("yyyy-MM-dd");

            int i=0;
            int pre = 0;
            int abs = 0;
            using (SqlConnection con = new SqlConnection(sqlcon))
            {
                con.Open();

                string sql1 = "SELECT cid,tp FROM cource WHERE cname='" + sub.Text + "'";
                SqlCommand cmd1 = new SqlCommand(sql1, con);
                using (SqlDataReader r = cmd1.ExecuteReader())
                {
                    while (r.Read())
                    {
                        pid = r["cid"].ToString();
                        tp = int.Parse(r["tp"].ToString());
                    }
                }
                tp++;
                string sql = "UPDATE cource set tp='" + tp + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                con.Close();
                while (i <= n)
                {
                    try
                    {




                        con.Open();
                        if (dg.Rows[i].Cells[2].Value.ToString() == "Absent")
                        {
                            p = "A";
                            abs++;
                        }
                        else if (dg.Rows[i].Cells[2].Value.ToString() == "Present")
                        {
                            pre++;
                            p = "P";
                        }
                        else if (dg.Rows[i].Cells[2].Value.ToString() == "Absent")
                        {
                            p = "A";
                            abs++;
                        }

                        string id = dg.Rows[i].Cells[0].Value.ToString();
                        string sql2 = "INSERT INTO [" + pid + "](studentID,Aclass,dt) VALUES('" + id + "','" + p + "','" + d + "')";
                        SqlCommand cmd2 = new SqlCommand(sql2, con);

                        cmd2.ExecuteNonQuery();
                        i++;
                        con.Close();
                    }

                    catch (Exception E)
                    {
                        MessageBox.Show(E.Message);
                    }
                }
            }
            MessageBox.Show("Attendance submited\n\n Absent :"+abs+"\n\nPresent : "+pre);
        }

        private void Semester_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(sqlcon))
            {
                con.Open();
                string sql = "SELECT cname FROM cource WHERE sem='" + Semester.Text + "' AND dep='CSE'";
                SqlCommand cmd = new SqlCommand(sql, con);
                using (SqlDataReader r = cmd.ExecuteReader())
                {
                    while (r.Read())
                    {
                        sub.Items.Add(r["cname"]).ToString();
                    }
                }
                con.Close();
            }
        }

        private void pora_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void sub_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
