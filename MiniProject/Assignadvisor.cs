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
    public partial class Assignadvisor : Form
    {
        SqlConnection conn = DatabaseConnection.getInstance().getConnection();
        SqlDataReader dr;
        
        public Assignadvisor()
        {

            InitializeComponent();
            panel1.Hide();
            AdvisorRole.Hide();
            SqlCommand cm = new SqlCommand("Select Id, Designation, Salary from [Advisor] EXCEPT Select A.AdvisorId, h.Designation , h.Salary From ProjectAdvisor A INNER JOIN Advisor h ON h.Id= A.AdvisorId", conn);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                int n = dataGridView3.Rows.Add();
                dataGridView3.Rows[n].Cells[0].Value = (int)dr.GetValue(0);
                //dataGridView2.Rows[n].Cells[1].Value = dr.GetValue(1);
                if (Convert.ToInt16(dr.GetValue(1)) == 6)
                {
                    dataGridView3.Rows[n].Cells[1].Value = "Professor";
                }
                if (Convert.ToInt16(dr.GetValue(1)) == 7)
                {
                    dataGridView3.Rows[n].Cells[1].Value = "Associate Professor";
                }
                if (Convert.ToInt16(dr.GetValue(1)) == 8)
                {
                    dataGridView3.Rows[n].Cells[1].Value = "Assisstant Professor";
                }
                if (Convert.ToInt16(dr.GetValue(1)) == 9)
                {
                    dataGridView3.Rows[n].Cells[1].Value = "Lecturer";
                }
                if (Convert.ToInt16(dr.GetValue(1)) == 10)
                {
                    dataGridView3.Rows[n].Cells[1].Value = "Industry Professional";
                }
                dataGridView3.Rows[n].Cells[2].Value = Convert.ToDecimal(dr.GetValue(2));
            }
            dr.Close();
            panel1.Hide();

            //SqlCommand cm1 = new SqlCommand("Select B.GroupId, A.Title, B.ProjectId from [GroupProject] B INNER JOIN [Project] A ON A.Id = B.ProjectId EXCEPT Select E.GroupId, C.Title, D.ProjectId From [ProjectAdvisor] D INNER JOIN [Project] C ON D.ProjectId = C.Id INNER JOIN [GroupProject] E ON E.ProjectID = C.Id ", conn);
            SqlCommand cm1 = new SqlCommand("Select B.GroupId, A.Title, B.ProjectId from [GroupProject] B INNER JOIN [Project] A ON A.Id = B.ProjectId ", conn);
            dr = cm1.ExecuteReader();
            while (dr.Read())
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = (int)dr.GetValue(0);
                dataGridView1.Rows[n].Cells[1].Value = (int)dr.GetValue(2);
                dataGridView1.Rows[n].Cells[2].Value = dr.GetString(1);

            }
            dr.Close();
            conn.Close();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
    }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            panel1.Show();

        }

        private void dataGridView3_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //AdvisorRole.Show();
            int id = Convert.ToInt32(dataGridView3.Rows[e.RowIndex].Cells["AdvisrId"].Value);
            int id5 = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ProjectId"].Value);
            textBox1.Text = Convert.ToString(id);
            textBox2.Text = Convert.ToString(id5);
            AdvisorRole.Show();
                
               /** if (comboBox1.Text != "")
                {
                    AdvisorRole.Hide();
                }
                else
                {
                    MessageBox.Show("Choose advisor role first");
                }
                **/
                
                //panel1.Hide();
                //panel2.Hide();
                //dataGridView3.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want to Assign this?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //panel3.Show();
                //comboBox1.Show();

                conn.Open();

                string ab = "ADVISOR_ROLE";
                //string n = string.Format("Select Id from Lookup where Category=@category");
                string cmd = String.Format("SELECT Id FROM dbo.Lookup WHERE Category = @Category and Value=@Value");
                SqlCommand n = new SqlCommand(cmd, conn);
                n.Parameters.Add(new SqlParameter("@Category", ab));
                n.Parameters.Add(new SqlParameter("@Value", comboBox1.Text));
                int id1 = (int)n.ExecuteScalar();
                //panel3.Hide();

                string m1 = String.Format("INSERT INTO [ProjectAdvisor](ProjectId, AdvisorId, AssignmentDate, AdvisorRole) values('{0}', '{1}', '{2}', '{3}' )", Convert.ToInt16(textBox2.Text), Convert.ToInt16(textBox1.Text), DateTime.Now, id1);
                SqlCommand command1 = new SqlCommand(m1, conn);
                //command1.Parameters.Add(new SqlParameter("@Id", id));
                int rows1 = command1.ExecuteNonQuery();
                if (rows1 != 0)
                {
                    MessageBox.Show("Assigned");
                }
                conn.Close();
                this.Close();

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
