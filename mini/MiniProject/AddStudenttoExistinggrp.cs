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
    public partial class AddStudenttoExistinggrp : Form
    {
        SqlConnection conn = DatabaseConnection.getInstance().getConnection();
        SqlDataReader dr;
        public AddStudenttoExistinggrp()
        {
            InitializeComponent();
            panel1.Hide();

            if (conn.State == System.Data.ConnectionState.Open)
            {
                try
                {
                    SqlCommand cm1 = new SqlCommand("Select S.Id, P.FirstName, P.LastName, S.RegistrationNo from Person P Inner join Student S on P.Id = S.Id EXCEPT Select G.StudentId, P.FirstName, P.LastName, S.RegistrationNo from [GroupStudent] G INNER JOIN STUDENT S ON G.StudentId= S.Id INNER JOIN Person P ON P.Id=G.StudentId", conn);
                    dr = cm1.ExecuteReader();
                    while (dr.Read())
                    {
                        int n = dataGridView2.Rows.Add();
                        dataGridView2.Rows[n].Cells[0].Value = (int)dr.GetValue(0);
                        dataGridView2.Rows[n].Cells[1].Value = (dr.GetString(1) + dr.GetString(2));
                        dataGridView2.Rows[n].Cells[2].Value = dr.GetValue(3);
                    }
                    //conn.Close();
                    dr.Close();
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
                        int n = dataGridView2.Rows.Add();
                        dataGridView2.Rows[n].Cells[0].Value = (int)dr.GetValue(0);
                        dataGridView2.Rows[n].Cells[1].Value = (dr.GetString(1) + dr.GetString(2));
                        dataGridView2.Rows[n].Cells[2].Value = dr.GetValue(3);
                    }
                    //conn.Close();
                    dr.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            try
            {
                SqlCommand cm = new SqlCommand("Select Id, Created_On From [Group] ", conn);
                SqlDataReader dr;
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = (int)dr.GetValue(0);
                    dataGridView1.Rows[n].Cells[1].Value = dr.GetValue(1);
                    //dataGridView1.Rows[n].Cells[2].Value = dr.GetValue(2);
                    //dataGridView1.Rows[n].Cells[3].Value = dr.GetValue(3);
                };
                
                dr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();


        }

        private void AddStudenttoExistinggrp_Load(object sender, EventArgs e)
        {
           // Edit_Panel.Hide();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete" && (e.RowIndex >= 0))
            {
                try
                {
                    if (MessageBox.Show("Are You Sure You Want to Delete this?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        conn.Open();
                        int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["GroupId"].Value);
                        string m = String.Format("DELETE FROM [Group] Where Id = @Id ");
                        SqlCommand command = new SqlCommand(m, conn);
                        command.Parameters.Add(new SqlParameter("@Id", id));

                        int rows = command.ExecuteNonQuery();
                        if (rows != 0)
                        {
                            MessageBox.Show("Data deleted!");
                            this.Hide();
                            AddStudenttoExistinggrp r = new AddStudenttoExistinggrp();
                            r.Show();
                        }
                        conn.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                conn.Close();
            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "AssignStudent" && (e.RowIndex >= 0))
            {
                panel1.Show();
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.Columns[e.ColumnIndex].Name == "Add_to_group" && (e.RowIndex >= 0))
            {
                conn.Open();
                try
                {
                    if (MessageBox.Show("Are You Sure You Want to Add this?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int id = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells["Id"].Value);

                        int id2 = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["GroupId"].Value);

                        string m1 = String.Format("INSERT INTO [GroupStudent](GroupId, StudentId, Status, AssignmentDate) values('{0}', '{1}', '{2}', '{3}' )", id2, id, 3, DateTime.Now);
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

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
