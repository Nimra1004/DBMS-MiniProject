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
    public partial class ManageProject : Form
    {
        SqlConnection conn = DatabaseConnection.getInstance().getConnection();
        
        
        
        public ManageProject()
        {
            InitializeComponent();
            
            Edit_Panel.Hide();
            try
            {
                SqlCommand cm = new SqlCommand("Select Id, Title, Description From Project ", conn);
                SqlDataReader dr;
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = (int)dr.GetValue(0);
                    dataGridView1.Rows[n].Cells[1].Value = dr.GetString(1);
                    dataGridView1.Rows[n].Cells[2].Value = dr.GetString(2);
                };
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }

        private void Add_Project_Click(object sender, EventArgs e)
        {
            
        }

        private void ManageProject_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete" && (e.RowIndex >= 0))
            {

                try
                {
                    conn.Open();
                    if (MessageBox.Show("Are You Sure You Want to Delete this?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);
                        int rows1 = 0;
                        int rows2 = 0;
                        string m1 = String.Format("DELETE FROM GroupProject Where ProjectId = @Id ");
                        SqlCommand command1 = new SqlCommand(m1, conn);
                        command1.Parameters.Add(new SqlParameter("@Id", id));
                        if (command1.ExecuteNonQuery() > 0)
                        {
                            rows1 = command1.ExecuteNonQuery();
                        }

                        string m2 = String.Format("DELETE FROM ProjectAdvisor Where ProjectId = @Id ");
                        SqlCommand command2 = new SqlCommand(m2, conn);
                        command2.Parameters.Add(new SqlParameter("@Id", id));
                        if (command2.ExecuteNonQuery() > 0)
                        {
                            rows2 = command1.ExecuteNonQuery();
                        }


                        string m = String.Format("DELETE FROM Project Where Id = @Id ");
                        SqlCommand command = new SqlCommand(m, conn);
                        command.Parameters.Add(new SqlParameter("@Id", id));
                        int rows = command.ExecuteNonQuery();
                        if (rows != 0 || (rows1 > 0 && rows2 > 0))
                        {
                            MessageBox.Show("Data deleted!");
                            this.Close();
                            ManageProject D = new ManageProject();
                            D.Show();
                        }
                    }
                    conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }

            else if (dataGridView1.Columns[e.ColumnIndex].Name == "Edit" && (e.RowIndex >= 0))
            {
                if (MessageBox.Show("Are You Sure You Want to Update this?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    Edit_Panel.Show();
                    conn.Open();
                    int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);
                    SqlCommand cm = new SqlCommand("Select P.Id, P.Title, P.Description from Project P  where P.Id=@Id ", conn);
                    cm.Parameters.Add(new SqlParameter("@Id", id));
                    SqlDataReader dr;
                    dr = cm.ExecuteReader();
                    try
                    {
                        while (dr.Read())
                        {
                            TitleTxt.Text = dr.GetString(1);
                            DescriptionTxt.Text = dr.GetString(2);
                            textBox1.Text = Convert.ToString(dr.GetValue(0));
                        }
                        dr.Close();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    conn.Close();
                }
                else
                {
                   // MessageBox.Show("");
                }
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            TitleTxt.Text = "";
            DescriptionTxt.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Edit_Panel.Hide();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            
            Project C1 = new Project();
            C1.set_Description(DescriptionTxt.Text);
            C1.set_Title(TitleTxt.Text);
            if ((C1.Get_Description() != null) && (C1.Get_Title() != null))
            {
                try
                {
                    conn.Open();
                    int ID = Convert.ToInt32(textBox1.Text);
                    string cmd2 = String.Format("UPDATE Project SET Description = @Description, Title=@Title Where Id = @Id ");
                    SqlCommand command2 = new SqlCommand(cmd2, conn);
                    command2.Parameters.Add(new SqlParameter("@Id", ID));

                    command2.Parameters.Add(new SqlParameter("@Description", SqlDbType.VarChar));
                    command2.Parameters["@Description"].Value = C1.Get_Description();
                    command2.Parameters.Add(new SqlParameter("@Title", SqlDbType.VarChar));
                    command2.Parameters["@Title"].Value = C1.Get_Title();


                    int rows2 = command2.ExecuteNonQuery();
                    if (rows2 != 0)
                    {
                        MessageBox.Show("Project Details Updated");
                        
                        Edit_Panel.Hide();
                        this.Close();
                        //ManageProject o = new ManageProject();
                        ManageProject D = new ManageProject();
                        D.Show();
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
                MessageBox.Show("Invalid Data!." +
                 "Please Enter Valid Data");
                conn.Close();
            }
        }

        private void Edit_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void gg_Click(object sender, EventArgs e)
        {
            this.Close();
            Form3 S = new Form3();
            S.Show();
            
        }

        private void label8_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
