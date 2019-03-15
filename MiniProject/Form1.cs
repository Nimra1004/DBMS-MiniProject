using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProject
{
    public partial class Form1 : Form
    {   
       
        


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
    }
}
