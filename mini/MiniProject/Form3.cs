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
    public partial class Form3 : Form
    {
        SqlConnection conn = DatabaseConnection.getInstance().getConnection();
        public Form3()
        {
            InitializeComponent();
            label4.Visible = false;
            label5.Visible = false;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            //radioButton1.Text
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            TitleTxt.Text = "";
            DescriptionTxt.Text = "";
            label4.Visible = false;
            label5.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            label4.Visible = false;
            label5.Visible = false;
            Project C1 = new Project();
            C1.set_Description(DescriptionTxt.Text);
            C1.set_Title(TitleTxt.Text);
            if (((C1.Get_Description()!= null ) || (DescriptionTxt.Text != "")) && ((C1.Get_Title()!= null) || (TitleTxt.Text != "")))
            {
                try
                {
                    String cmd1 = String.Format("INSERT INTO Project(Title, Description) values('{0}', '{1}')", C1.Get_Title(), C1.Get_Description());
                    int rows = DatabaseConnection.getInstance().exectuteQuery(cmd1);
                    if (rows != 0)
                    {
                        MessageBox.Show("Data Recorded Succesfully");
                        Cancel_Click(sender, e);
                        
                    }
                    conn.Close();
                    if (MessageBox.Show("Do you Want to Add Another Project's Data?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        this.Show();
                    }
                    else
                    {
                        this.Close();
                        ManageProject t = new ManageProject();
                        t.Show();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                label4.Text = "Invalid Title";
                label5.Text = "Invalid Description";
                label4.Visible = true;
                label5.Visible = true;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
