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
    public partial class Student : UserControl
    {
        //string p;
        string ms;
        int to, tt, cmp, qu;
        int i;
        int n;
        int td;
        string pid;
        int preh=0;
        float pre=0;
        float ateen=0;
        int k = 0;

        private void Semester_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(sqlcon))
            {
                con.Open();
                string sql = "SELECT cname,tp FROM cource WHERE sem='" + Semester.Text + "' AND dep='CSE'";
                SqlCommand cmd = new SqlCommand(sql, con);
                using (SqlDataReader r = cmd.ExecuteReader())
                {
                    while (r.Read())
                    {
                        sub.Items.Add(r["cname"]).ToString();
                        td = int.Parse(r["tp"].ToString());
                    }
                }
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }

        string sqlcon = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\ELDHOS AJI\source\repos\university_project-master\UP\UP\university_project\sms\sms\db.mdf"";Integrated Security=True";

        public Student()
        {
            InitializeComponent();
        }

        private void sub_SelectedIndexChanged(object sender, EventArgs e)
        {
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
                        td = int.Parse(r["tp"].ToString());
                    }
                        
                }

                int ptt = 0;
                string p = "P";
                SqlCommand cmd4 = new SqlCommand("SELECT * FROM [" + pid + "] WHERE studentID=" + dg.Rows[n].Cells[0].Value.ToString() + " AND Aclass="+p+" ", con);
                using (SqlDataReader dtt = cmd4.ExecuteReader())
                {
                    while (dtt.Read())
                    {
                        ptt++;
                    }
                }
                SqlCommand cmd3 = new SqlCommand("SELECT t1,t2,qu,assi FROM [" + ms + "] WHERE studentID=" + dg.Rows[n].Cells[0].Value.ToString() + " ", con);
                using (SqlDataReader dq = cmd3.ExecuteReader())
                {
                    while (dq.Read())
                    {

                        to = Convert.ToInt16(dq["t1"].ToString());
                        tt = Convert.ToInt16(dq["t2"].ToString());
                        int assi = Convert.ToInt16(dq["assi"].ToString());
                        qu = Convert.ToInt16(dq["qu"].ToString());

                        preh = (to + tt + assi + qu);
                        pre = preh / (120);
                        ateen = ptt / td;

                    }
                    dg.Rows[n].Cells[2].Value = preh.ToString(); ;
                    dg.Rows[n].Cells[3].Value = ateen.ToString();
                }


                ms = pid + "m";
                SqlCommand cmd = new SqlCommand("SELECT studentID,studentName FROM student WHERE ssection='" + Section.Text + "' AND ssem='" + Semester.Text + "'", con);
                using (SqlDataReader d = cmd.ExecuteReader())
                {
                    while (d.Read())
                    {
                        i++;
                        n = dg.Rows.Add();
                        dg.Rows[n].Cells[0].Value = d["studentID"].ToString();
                        dg.Rows[n].Cells[1].Value = d["studentName"].ToString();
                        dg.Rows[n].Cells[2].Value = 74 ;
                        dg.Rows[n].Cells[3].Value = 45;
                        dg.Rows[n].Cells[4].Value = "NP";

                    }
                }
                con.Close();
            }

                
              
                //  SqlDataAdapter sd = new SqlDataAdapter("SELECT studentID,studentName FROM student WHERE ssection='" + Section.Text + "'", con);
                //  DataTable dt = new DataTable();
                // sd.Fill(dt);
                // sid.dis = "";
            }
            }
        }

