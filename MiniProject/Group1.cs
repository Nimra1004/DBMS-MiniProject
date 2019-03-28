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
    public partial class Group1 : Form
    {
        SqlConnection conn = DatabaseConnection.getInstance().getConnection();
        SqlDataReader dr;
        //int counter = 0;

        public Group1()
        {

            InitializeComponent();
            //panel3.Hide();
            //bool j = conn.Open();
            if (conn.State == System.Data.ConnectionState.Open)
            {
                try
                {
                    SqlCommand cm1 = new SqlCommand("Select S.Id, P.FirstName, P.LastName, S.RegistrationNo from Person P Inner join Student S on P.Id = S.Id EXCEPT Select G.StudentId, P.FirstName, P.LastName, S.RegistrationNo from [GroupStudent] G INNER JOIN STUDENT S ON G.StudentId= S.Id INNER JOIN Person P ON P.Id=G.StudentId", conn);
                    dr = cm1.ExecuteReader();
                    while (dr.Read())
                    {
                        int n = dataGridView1.Rows.Add();
                        dataGridView1.Rows[n].Cells[0].Value = (int)dr.GetValue(0);
                        dataGridView1.Rows[n].Cells[1].Value = (dr.GetString(1) + dr.GetString(2));
                        dataGridView1.Rows[n].Cells[2].Value = dr.GetValue(3);
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                conn.Open();
                try
                {
                    SqlCommand cm1 = new SqlCommand("Select S.Id, P.FirstName, P.LastName, S.RegistrationNo from Person P Inner join Student S on P.Id = S.Id EXCEPT Select G.StudentId, P.FirstName, P.LastName, S.RegistrationNo from [GroupStudent] G INNER JOIN STUDENT S ON G.StudentId= S.Id INNER JOIN Person P ON P.Id=G.StudentId", conn);
                    dr = cm1.ExecuteReader();
                    while (dr.Read())
                    {
                        int n = dataGridView1.Rows.Add();
                        dataGridView1.Rows[n].Cells[0].Value = (int)dr.GetValue(0);
                        dataGridView1.Rows[n].Cells[1].Value = (dr.GetString(1) + dr.GetString(2));
                        dataGridView1.Rows[n].Cells[2].Value = dr.GetValue(3);
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Group_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ADD_Group v = new ADD_Group();
            //v.set_created_on(dateTimePicker1.Value);
            
        }
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //int i = 0;
            
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Add_to_group" && (e.RowIndex >= 0))
            {
                conn.Open();
                try
                {
                    if (MessageBox.Show("Are You Sure You Want to Add this?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);

                        string g = string.Format("Select MAX(Id) From [Group]");
                        SqlCommand f = new SqlCommand(g, conn);
                        int Grp_id = (int)f.ExecuteScalar();

                        string m1 = String.Format("INSERT INTO [GroupStudent](GroupId, StudentId, Status, AssignmentDate) values('{0}', '{1}', '{2}', '{3}' )", Grp_id, id, 3, DateTime.Now);
                        SqlCommand command1 = new SqlCommand(m1, conn);
                        //command1.Parameters.Add(new SqlParameter("@Id", id));
                        int rows1 = command1.ExecuteNonQuery();
                        if (rows1 != 0)
                        {
                            MessageBox.Show("Added");
                            //counter = counter + 1;
                            if (MessageBox.Show("Do you want to add another student?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                            {
                                //MessageBox.Show("Assign at least two students to a group");
                                this.Close();
                                    //Group1 b = new Group1();
                                    
                            }
                            else
                            {
                                Group1 b = new Group1();
                                b.Show();
                            }
                        }
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    }
