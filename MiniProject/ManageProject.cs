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
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Add_Project_Click(object sender, EventArgs e)
        {
            Form3 s1 = new Form3();
            s1.Show();
        }

        private void ManageProject_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            conn.Open();
            try
            {
                if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete" && (e.RowIndex >= 0))
                {
                    if (MessageBox.Show("Are You Sure You Want to Delete this?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);
                        string m = String.Format("DELETE FROM Project Where Id = @Id ");
                        SqlCommand command = new SqlCommand(m, conn);
                        command.Parameters.Add(new SqlParameter("@Id", id));
                        int rows = command.ExecuteNonQuery();
                        if (rows != 0)
                        {
                            MessageBox.Show("Data deleted!");
                            this.Hide();
                            ManageProject D = new ManageProject();
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
                if (MessageBox.Show("Are You Sure You Want to Delete this?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            TitleTxt.Text = " ";
            DescriptionTxt.Text = " ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Edit_Panel.Hide();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            conn.Open();
            Project C1 = new Project();
            C1.set_Description(DescriptionTxt.Text);
            C1.set_Title(TitleTxt.Text);
            if ((C1.Get_Description() != null) && (C1.Get_Title() != null))
            {
                try
                {
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
                        conn.Close();
                        Edit_Panel.Hide();
                        ManageProject o = new ManageProject();
                    }
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
            }
        }

        private void Edit_Panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
