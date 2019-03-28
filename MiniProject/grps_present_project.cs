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
    public partial class grps_present_project : Form
    {
        SqlConnection conn = DatabaseConnection.getInstance().getConnection();
        SqlDataReader dr;
        
        public grps_present_project()
        {

            InitializeComponent();
            panel1.Hide();
            SqlCommand cm1 = new SqlCommand("Select G.Id, G.Created_On from [Group] G EXCEPT Select P.Id, P.Created_On from [Group] P INNER JOIN [GroupProject] S ON P.Id = S.GroupId ", conn);
            dr = cm1.ExecuteReader();
            while (dr.Read())
            {

                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = (int)dr.GetValue(0);
                dataGridView1.Rows[n].Cells[1].Value = Convert.ToDateTime(dr.GetValue(1));
                //dataGridView1.Rows[n].Cells[2].Value = dr.GetValue(3);
                //dataGridView1.Rows[n].Cells[1].Value = 
            }



            conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            panel1.Show();
            conn.Open();
            SqlCommand cm2 = new SqlCommand("Select p.Id, p.Description, p.Title from [Project] p EXCEPT Select g.ProjectId, C.Description, C.Title From [GroupProject] g INNER JOIN [Project] C ON g.ProjectId= C.Id ", conn);
            dr = cm2.ExecuteReader();
            while (dr.Read())
            {
                int n = dataGridView2.Rows.Add();
                dataGridView2.Rows[n].Cells[0].Value = (int)dr.GetValue(0);
                dataGridView2.Rows[n].Cells[1].Value = dr.GetString(1);
                dataGridView2.Rows[n].Cells[2].Value = dr.GetString(2);
            }
            dr.Close();
            conn.Close();
            
            //groupProject g = new groupProject();
            //g.Show();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            conn.Open();
            int id1 = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);
            
            try
            {
                if (MessageBox.Show("Are You Sure You Want to Add this?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells["projectid"].Value);

                    /**string g = string.Format("Select MAX(Id) From [Group]");
                    SqlCommand f = new SqlCommand(g, conn);
                    int Grp_id = (int)f.ExecuteScalar();**/

                    string m = String.Format("Select Id From [Project] where Id=@Id");
                    SqlCommand command = new SqlCommand(m, conn);
                    command.Parameters.Add(new SqlParameter("@Id", id));
                    //command.Parameters["@Id"].Value = id;
                    int s_id = (int)command.ExecuteScalar();

                    string m1 = String.Format("INSERT INTO [GroupProject](GroupId, ProjectId, AssignmentDate) values('{0}', '{1}', '{2}' )", id1, s_id, DateTime.Now);
                    SqlCommand command1 = new SqlCommand(m1, conn);
                    //command1.Parameters.Add(new SqlParameter("@Id", id));
                    int rows1 = command1.ExecuteNonQuery();
                    if (rows1 != 0)
                    {
                        MessageBox.Show("Added");
                        this.Hide();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
            //this.Hide();
    }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void grps_present_project_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
