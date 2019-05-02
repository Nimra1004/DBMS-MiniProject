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
    public partial class Addadviser : Form
    {
        SqlConnection conn = DatabaseConnection.getInstance().getConnection();
        public Addadviser()
        {
            InitializeComponent();
            label16.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label17.Visible = false;

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            

        }

        private void CANCEL_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void SUMBIT_Click(object sender, EventArgs e)
        {
            
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Addadviser_Load(object sender, EventArgs e)
        {

        }

       

        private void CLEAR_Click(object sender, EventArgs e)
        {
            advisercombo.Text = "";
            Salarytxt.Text = "";
            FirstName.Text = "";
            LastName.Text = "";
            Email.Text = "";
            Contact.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            label16.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label17.Visible = false;
        }

        private void CANCEL_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SUMBIT_Click_1(object sender, EventArgs e)
        {
            label16.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label17.Visible = false;
            int id9 = 0;
            if (conn.State != System.Data.ConnectionState.Open)
            {
                conn.Open();
                if (Email.Text != "")
                {
                    string cmd = String.Format("SELECT Email FROM Person WHERE Email= @Email");
                    SqlCommand command = new SqlCommand(cmd, conn);
                    //command.Parameters.Add(new SqlParameter("@Category", ab));
                    command.Parameters.Add(new SqlParameter("@Email", Email.Text));
                    id9 = command.ExecuteNonQuery();

                }
            }
            else
            {
                if (Email.Text != "")
                {
                    string cmd = String.Format("SELECT Email FROM Person WHERE Email= @Email");
                    SqlCommand command = new SqlCommand(cmd, conn);
                    //command.Parameters.Add(new SqlParameter("@Category", ab));
                    command.Parameters.Add(new SqlParameter("@Email", Email.Text));
                    id9 = command.ExecuteNonQuery();

                }
            }
            string value = "";
            bool isChecked = radioButton1.Checked;
            if (isChecked)
                value = radioButton1.Text;
            else
                value = radioButton2.Text;

            Adviser C1 = new Adviser();
            C1.set_First_Name(FirstName.Text);
            C1.set_Last_Name(LastName.Text);
            C1.set_Contact(Contact.Text);
            C1.set_Email(Email.Text);
            C1.set_Gender(value);
            C1.set_DOB(dateTimePicker1.Value);
            C1.set_Designation(advisercombo.Text);
            C1.set_Salary(Salarytxt.Text);
            bool a = false;
            bool b = false;
            bool c = false;
            bool d = false;
            bool f = false;
            bool g = false;
            bool h = false;
            bool j = false;
            bool k = false;
            if (C1.Get_First_Name() == null || LastName.Text == "")
            {
                a = true;
                label10.Text = "Invalid First Name";
                label10.Visible = true;
            }
            if (C1.Get_Last_Name() == null || LastName.Text == "")
            {
                c = true;
                label11.Text = "Invalid Last Name";
                label11.Visible = true;
            }
            if (C1.Get_Contact() == null || Contact.Text == "")
            {
                d = true;
                label12.Text = "Invalid Contact";
                label12.Visible = true;
            }
            if (C1.Get_Email() == null ||( Email.Text == "" || id9 > 0))
            {
                f = true;
                label13.Text = "Invalid Email";
                label13.Visible = true;
            }
            if (C1.Get_Gender() == null || (radioButton1.Checked == false && radioButton2.Checked == false))
            {
                g = true;
                label15.Text = "Invalid Gender";
                label15.Visible = true;

            }
            if (C1.Get_DOB() == null)
            {
                h = true;
                label14.Text = "Invalid Date Of Birth";
                label14.Visible = true;
            }
            if (C1.Get_Salary() == 0 || Salarytxt.Text == "")
            {
                j = true;
                label16.Text = "Invalid Salary";
                label16.Visible = true;

            }
            if (C1.Get_Designation() == null || advisercombo.Text == "")
            {
                k = true;
                label17.Text = "Invalid Designation";
                label17.Visible = true;

            }
            if (a == true || b == true || c == true || d == true || f == true || g == true || h == true || j == true || k == true)
            {

                //MessageBox.Show("Invalid Data!." +
                //"Please Enter Valid Data");
                
            }
            else
            {

                string ab = "GENDER";
                string cmd = String.Format("SELECT Id FROM dbo.Lookup WHERE Category = @Category and Value=@Value");
                SqlCommand command = new SqlCommand(cmd, conn);
                command.Parameters.Add(new SqlParameter("@Category", ab));
                command.Parameters.Add(new SqlParameter("@Value", value));
                int id = (int)command.ExecuteScalar();

                string cd = "DESIGNATION";
                string cmd4 = String.Format("SELECT Id FROM dbo.Lookup WHERE Category = @Category and Value=@Value");
                SqlCommand command4 = new SqlCommand(cmd4, conn);
                command4.Parameters.Add(new SqlParameter("@Category", cd));
                command4.Parameters.Add(new SqlParameter("@Value", advisercombo.Text));
                int id_lookup = (int)command4.ExecuteScalar();

                String cmd1 = String.Format("INSERT INTO Person(FirstName, LastName, Contact, Email, DateofBirth, Gender) values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", C1.Get_First_Name(), C1.Get_Last_Name(), C1.Get_Contact(), C1.Get_Email(), C1.Get_DOB(), id);
                int rows = DatabaseConnection.getInstance().exectuteQuery(cmd1);

                string cmd2 = String.Format("SELECT MAX(Id) FROM dbo.Person");
                SqlCommand command1 = new SqlCommand(cmd2, conn);
                int id2 = (int)command1.ExecuteScalar();
                try
                {
                    String cmd3 = String.Format("INSERT INTO Advisor(Id, Designation, Salary) values('{0}', '{1}', '{2}')", id2, id_lookup, C1.Get_Salary());
                    int rows2 = DatabaseConnection.getInstance().exectuteQuery(cmd3);
                    if (rows != 0 && rows2 != 0)
                    {
                        MessageBox.Show("Data Recorded Succesfully");
                        Cancel_Click(sender, e);
                    }
                    conn.Close();
                    if (MessageBox.Show("Do you Want to Add Another Student's Data?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        this.Show();
                        label16.Visible = false;
                        label10.Visible = false;
                        label11.Visible = false;
                        label12.Visible = false;
                        label13.Visible = false;
                        label14.Visible = false;
                        label15.Visible = false;
                        label17.Visible = false;
                    }
                    else
                    {
                        this.Close();
                        ManageAdviser t = new ManageAdviser();
                        t.Show();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                }
            }
    }
}
