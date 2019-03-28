using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProject
{
    public partial class Form1 : Form
    {

        SqlConnection conn = DatabaseConnection.getInstance().getConnection();
        SqlDataReader dr;


        public Form1()
        {
            InitializeComponent();
            DataPanel.Hide();
            ManagePanel.Hide();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //this.Close();
            Student_Panel s1 = new Student_Panel();
            s1.Show();
            
        }

        private void Manage_student_Click(object sender, EventArgs e)
        {
            Dashboard D = new Dashboard();
            D.Show();
            
        }

        private void Add_Project_Click(object sender, EventArgs e)
        {
            
        }

        private void Projectbutton_Click(object sender, EventArgs e)
        {
            ManageProject p1 = new ManageProject();
            p1.Show();
            
        }

        private void AddEvaluationIcon_Click(object sender, EventArgs e)
        {
            
        }

        private void ManageEvaluation_Click(object sender, EventArgs e)
        {
            Eval_Dashboards r = new Eval_Dashboards();
            r.Show();
            
        }

        private void advisorpicbox_Click(object sender, EventArgs e)
        {
            
        }

        private void ManageAdvisor_Click(object sender, EventArgs e)
        {
            ManageAdviser A = new ManageAdviser();
            A.Show();
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Managebtn_Click(object sender, EventArgs e)
        {
            
        }

        private void mnage_Click(object sender, EventArgs e)
        {
            ManagePanel.Show();
            DataPanel.Hide();
        }

        private void Add_Project_Click_1(object sender, EventArgs e)
        {
            Form3 s2 = new Form3();
            s2.Show();
            
        }

        private void AddEvaluationIcon_Click_1(object sender, EventArgs e)
        {
            AddEvaluation p2 = new AddEvaluation();
            p2.Show();
            
        }

        private void advisorpicbox_Click_1(object sender, EventArgs e)
        {
            Addadviser a = new Addadviser();
            a.Show();
            
        }

        private void Managebtn_Click_1(object sender, EventArgs e)
        {
            DataPanel.Show();
            ManagePanel.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Group1 g = new Group1();
            g.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                try
                {
                    //conn.Open();
                    string k = String.Format("INSERT INTO [Group](Created_On) values('{0}')", DateTime.Now);
                    //String cmd3 = String.Format("INSERT INTO Student(Id, RegistrationNo) values('{0}', '{1}')", id2, C1.Get_Reg_No());
                    SqlCommand f = new SqlCommand(k, conn);
                    int Grp_id = f.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Group1 g = new Group1();
                g.Show();
            }
            else
            {
                conn.Open();
                try
                {
                    //conn.Open();
                    string k = String.Format("INSERT INTO [Group](Created_On) values('{0}')", DateTime.Now);
                    //String cmd3 = String.Format("INSERT INTO Student(Id, RegistrationNo) values('{0}', '{1}')", id2, C1.Get_Reg_No());
                    SqlCommand f = new SqlCommand(k, conn);
                    int Grp_id = f.ExecuteNonQuery();
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Group1 g = new Group1();
                g.Show();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            grps_present_project p = new grps_present_project();
            p.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Assignadvisor h = new Assignadvisor();
            h.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            markevaluations g = new markevaluations();
            g.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddStudenttoExistinggrp h = new AddStudenttoExistinggrp();
            h.Show();
        }
    }
}
