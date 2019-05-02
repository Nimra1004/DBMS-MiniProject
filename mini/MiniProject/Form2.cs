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
    public partial class Student_Panel : Form
    {
        SqlConnection conn = DatabaseConnection.getInstance().getConnection();
        private List<Student> Students = new List<Student>();
        internal List<Student> Students1 { get => Students; set => Students = value; }
        public Student_Panel()
        {
            InitializeComponent();
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void Student_Panel_Load(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            try
            {
                string value = "";
                bool isChecked = radioButton1.Checked;
                if (isChecked)
                    value = radioButton1.Text;
                else
                    value = radioButton2.Text;

                Student C1 = new Student();
                C1.set_First_Name(FirstName.Text);
                C1.set_Reg_No(RegistrationNo.Text);
                C1.set_Last_Name(LastName.Text);
                C1.set_Contact(Contact.Text);
                C1.set_Email(Email.Text);
                C1.set_Gender(value);
                C1.set_DOB(dateTimePicker1.Value);
                bool a = false;
                bool b = false;
                bool c = false;
                bool d = false;
                bool f = false;
                bool g = false;
                bool h = false;
                if (C1.Get_First_Name() == null || FirstName.Text == "")
                {
                    a = true;
                    label9.Text = "Invalid First Name";
                    label9.Visible = true;
                }
                if (C1.Get_Reg_No() == null )
                {
                    b = true;
                    
                    label15.Text = "Invalid Registration Number";
                    label15.Visible = true;
                }
                if (C1.Get_Last_Name() == null || LastName.Text == "")
                {
                    c = true;
                    label10.Text = "Invalid Last Name";
                    label10.Visible = true;
                }
                if (C1.Get_Contact() == null)
                {
                    d = true;
                    label11.Text = "Invalid Contact";
                    label11.Visible = true;
                }
                if (C1.Get_Email() == null)
                {
                    f = true;
                    label12.Text = "Invalid Email";
                    label12.Visible = true;
                }
                if (C1.Get_Gender() == null || (radioButton1.Checked == false && radioButton2.Checked == false))
                {
                    g = true;
                    
                    label14.Text = "Invalid Gender";
                    label14.Visible = true;
                }
                if (C1.Get_DOB() == null)
                {
                    h = true;
                    label13.Text = "Invalid Date Of Birth";
                    label3.Visible = true;
                }

                if (a == true || b == true || c == true || d == true || f == true || g == true || h == true)
                {
                    // MessageBox.Show("Invalid Submission attempt!! ");
                    //Cancel_Click(sender, e);


                }
                else
                {
                    
                    Students1.Add(C1);
                    string ab = "GENDER";
                    string cmd = String.Format("SELECT Id FROM dbo.Lookup WHERE Category = @Category and Value=@Value");
                    SqlCommand command = new SqlCommand(cmd, conn);
                    command.Parameters.Add(new SqlParameter("@Category", ab));
                    command.Parameters.Add(new SqlParameter("@Value", value));
                    int id = (int)command.ExecuteScalar();

                    String cmd1 = String.Format("INSERT INTO Person(FirstName, LastName, Contact, Email, DateofBirth, Gender) values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", C1.Get_First_Name(), C1.Get_Last_Name(), C1.Get_Contact(), C1.Get_Email(), C1.Get_DOB(), id);
                    int rows = DatabaseConnection.getInstance().exectuteQuery(cmd1);

                    string cmd2 = String.Format("SELECT MAX(Id) FROM dbo.Person");
                    SqlCommand command1 = new SqlCommand(cmd2, conn);
                    int id2 = (int)command1.ExecuteScalar();

                    String cmd3 = String.Format("INSERT INTO Student(Id, RegistrationNo) values('{0}', '{1}')", id2,C1.Get_Reg_No());
                    int rows2 = DatabaseConnection.getInstance().exectuteQuery(cmd3);
                    
                    if (rows != 0 && rows2 != 0)
                    {
                        MessageBox.Show("Data Recorded Succesfully");
                        Cancel_Click(sender, e);
                        label9.Visible = false;
                        label10.Visible = false;
                        label11.Visible = false;
                        label12.Visible = false;
                        label13.Visible = false;
                        label14.Visible = false;
                        label15.Visible = false;
                    }
                    conn.Close();
                    if (MessageBox.Show("Do you Want to Add Another Student's Data?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        this.Show();
                    }
                    else
                    {
                        this.Close();
                        Dashboard t = new Dashboard();
                        t.Show();
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            FirstName.Text = "";
            LastName.Text = "";
            Email.Text = "";
            Contact.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            RegistrationNo.Text = "";
            conn.Close();
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
        }

        private void Student_Panel_Load_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            conn.Close();
        }

        private void Gender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}