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

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            advisercombo.Text = "";
            Salarytxt.Text = "";
            FirstName.Text = " ";
            LastName.Text = " ";
            Email.Text = " ";
            Contact.Text = " ";
            dateTimePicker1.Value = DateTime.Now;
            radioButton1.Checked = false;
            radioButton2.Checked = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
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
            bool a = false;
            bool b = false;
            bool c = false;
            bool d = false;
            bool f = false;
            bool g = false;
            bool h = false;
            if (C1.Get_First_Name() == null)
            {
                a = true;
            }
            if (C1.Get_Last_Name() == null)
            {
                c = true;
            }
            if (C1.Get_Contact() == null)
            {
                d = true;
            }
            if (C1.Get_Email() == null)
            {
                f = true;
            }
            if (C1.Get_Gender() == null)
            {
                g = true;
            }
            if (C1.Get_DOB() == null)
            {
                h = true;
            }

            if (a == true || b == true || c == true || d == true || f == true || g == true || h == true)
            {

                MessageBox.Show("Invalid Data!." +
                    "Please Enter Valid Data");
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

                C1.set_Designation(advisercombo.Text);
                C1.set_Salary(Convert.ToDecimal(Salarytxt.Text));
                if ((C1.Get_Designation() != null) && (C1.Get_Salary() != decimal.Zero))
                {
                    try
                    {
                        String cmd3 = String.Format("INSERT INTO Advisor(Id, Designation, Salary) values('{0}', '{1}', '{2}')" , id2, id_lookup, C1.Get_Salary());
                        int rows2 = DatabaseConnection.getInstance().exectuteQuery(cmd3);
                        if (rows != 0 && rows2!=0)
                        {
                            MessageBox.Show("Data Recorded Succesfully");
                            Cancel_Click(sender, e);
                        }
                        conn.Close();
                        if (MessageBox.Show("Do you Want to Add Another Student's Data?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            this.Show();
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Addadviser_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
