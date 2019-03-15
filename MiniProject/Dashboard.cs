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
    public partial class Dashboard : Form
    {
        SqlConnection conn = DatabaseConnection.getInstance().getConnection();
        SqlDataReader dr;
        
        public Dashboard()
        {
            InitializeComponent();
            Edit_Panel.Hide();
            try
            {
                
                SqlCommand cm = new SqlCommand("Select P.Id, P.FirstName, P.LastName, P.Contact, P.Email, P.DateofBirth, P.Gender, S.RegistrationNo from Person P Inner join Student S on P.Id = S.Id ", conn);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = (int)dr.GetValue(0);
                    dataGridView1.Rows[n].Cells[1].Value = dr.GetString(1);
                    dataGridView1.Rows[n].Cells[2].Value = dr.GetString(2);
                    dataGridView1.Rows[n].Cells[3].Value = dr.GetValue(3);
                    dataGridView1.Rows[n].Cells[4].Value = dr.GetValue(4);
                    dataGridView1.Rows[n].Cells[5].Value = dr.GetValue(5);
                    
                    if((int)dr.GetValue(6) == 1)
                    {
                        dataGridView1.Rows[n].Cells[6].Value = "Male";
                    }
                    else
                    {
                        dataGridView1.Rows[n].Cells[6].Value = "Female";
                    }
                    dataGridView1.Rows[n].Cells[7].Value = dr.GetString(7);
                };
                conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Student_Panel s1 = new Student_Panel();
            s1.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            conn.Open();
            try
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "DELETE" && (e.RowIndex >= 0))
                {
                    if (MessageBox.Show("Are You Sure You Want to Delete this?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);
                        string m = String.Format("DELETE FROM Student Where Id = @Id ");
                        SqlCommand command = new SqlCommand(m, conn);
                        command.Parameters.Add(new SqlParameter("@Id", id));
                        int rows = command.ExecuteNonQuery();

                        string m1 = String.Format("DELETE FROM Person Where Id = @Id ");
                        SqlCommand command1 = new SqlCommand(m1, conn);
                        command1.Parameters.Add(new SqlParameter("@Id", id));
                        int rows1 = command1.ExecuteNonQuery();
                        if (rows != 0 && rows1 != 0)
                        {
                            MessageBox.Show("Data deleted!");
                            this.Hide();
                            Dashboard D = new Dashboard();
                            D.Show();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Edit" && (e.RowIndex >= 0))
            {
                if (MessageBox.Show("Are You Sure You Want to Update this?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    Edit_Panel.Show();
                    conn.Open();
                    int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);
                    SqlCommand cm = new SqlCommand("Select P.Id, P.FirstName, P.LastName, P.Contact, P.Email, P.DateofBirth, P.Gender, S.RegistrationNo from Person P Inner join Student S on P.Id = S.Id where P.Id=@Id ", conn);
                    cm.Parameters.Add(new SqlParameter("@Id", id));
                    dr = cm.ExecuteReader();
                    try
                    {
                        while (dr.Read())
                        {
                            FirstName.Text = dr.GetString(1);
                            Last_Name.Text = dr.GetString(2);
                            ContactTextBox.Text = dr.GetString(3);
                            EmailTxtBox.Text = dr.GetString(4);
                            dateTimePicker1.Value = (DateTime)dr.GetValue(5);
                            if ((int)dr.GetValue(6) == 1)
                            {
                                radioButton1.Checked = true;
                            }
                            else
                            {
                                radioButton2.Checked = true;
                            }
                            registrationtxt.Text = dr.GetString(7);
                            textBox1.Text = Convert.ToString(dr.GetValue(0));
                        }
                        dr.Close();
                        conn.Close();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                
             }
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            Edit_Panel.Hide();
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            FirstName.Text = " ";
            Last_Name.Text = " ";
            EmailTxtBox.Text = " ";
            ContactTextBox.Text = " ";
            dateTimePicker1.Value = DateTime.Now;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            registrationtxt.Text = " ";
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            try
            {
                string value = "";
                bool isChecked = radioButton1.Checked;
                if (isChecked)
                {
                    value = radioButton1.Text;
                }
                else
                {
                    value = radioButton2.Text;
                }

                Student C1 = new Student();
                C1.set_First_Name(FirstName.Text);
                C1.set_Reg_No(registrationtxt.Text);
                C1.set_Last_Name(Last_Name.Text);
                C1.set_Contact(ContactTextBox.Text);
                C1.set_Email(EmailTxtBox.Text);
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
                if (C1.Get_Reg_No() == null)
                {
                    b = true;
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
                    conn.Open();
                    string ab = "GENDER";
                    string cmd = String.Format("SELECT Id FROM dbo.Lookup WHERE Category = @Category and Value=@Value");
                    SqlCommand command = new SqlCommand(cmd, conn);
                    command.Parameters.Add(new SqlParameter("@Category", ab));
                    command.Parameters.Add(new SqlParameter("@Value", value));
                    int id = (int)command.ExecuteScalar();

                    //String cmd1 = String.Format("INSERT INTO Person(FirstName, LastName, Contact, Email, DateofBirth, Gender) values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", C1.Get_First_Name(), C1.Get_Last_Name(), C1.Get_Contact(), C1.Get_Email(), C1.Get_DOB(), id);
                    String cmd1 = String.Format("UPDATE Person SET FirstName = @FirstName, LastName = @LastName, Contact=@Contact, Email=@Email, DateofBirth=@DateofBirth, Gender=@Gender  Where Id = @Id");
                    SqlCommand command1 = new SqlCommand(cmd1, conn);
                    command1.Parameters.Add(new SqlParameter("@FirstName", SqlDbType.VarChar));
                    command1.Parameters["@FirstName"].Value = C1.Get_First_Name();

                    command1.Parameters.Add(new SqlParameter("@LastName", SqlDbType.VarChar));
                    command1.Parameters["@LastName"].Value = C1.Get_Last_Name();

                    command1.Parameters.Add(new SqlParameter("@Contact", SqlDbType.VarChar));
                    command1.Parameters["@Contact"].Value = C1.Get_Contact();

                    command1.Parameters.Add(new SqlParameter("@Email", SqlDbType.VarChar));
                    command1.Parameters["@Email"].Value = C1.Get_Email();

                    command1.Parameters.Add(new SqlParameter("@DateofBirth", SqlDbType.DateTime));
                    command1.Parameters["@DateofBirth"].Value = C1.Get_DOB();

                    command1.Parameters.Add(new SqlParameter("@Gender", id));
                    //command.Parameters["@conditionName"].Value = C1.Get_First_Name();
                    int ID = Convert.ToInt32(textBox1.Text);
                    command1.Parameters.Add(new SqlParameter("@Id", ID));


                    int rows = command1.ExecuteNonQuery();

                    string cmd2 = String.Format("UPDATE Student SET RegistrationNo = @RegistrationNo Where Id = @Id ");
                    SqlCommand command2 = new SqlCommand(cmd2, conn);
                    command2.Parameters.Add(new SqlParameter("@Id", ID));
                    command2.Parameters.Add(new SqlParameter("@RegistrationNo", SqlDbType.VarChar));
                    command2.Parameters["@RegistrationNo"].Value = C1.Get_Reg_No();


                    int rows2 = command2.ExecuteNonQuery();

                    if (rows != 0 && rows2 != 0)
                    {
                        MessageBox.Show("Data Updated Succesfully");
                        Cancel_Click(sender, e);
                        Edit_Panel.Hide();
                        this.Close();
                        Dashboard D = new Dashboard();
                        D.Show();
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            
        }

        private void label8_Click_1(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Student_Panel g = new Student_Panel();
            g.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
