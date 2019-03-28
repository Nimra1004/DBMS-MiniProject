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
    public partial class markevaluations : Form
    {
        SqlConnection conn = DatabaseConnection.getInstance().getConnection();
        SqlDataReader dr;
        
        public markevaluations()
        {
            InitializeComponent();
            panel1.Hide();
            SqlCommand da2 = new SqlCommand("Select G.Id, P.Title From [Group] G CROSS JOIN [Project] P", conn);
            dr = da2.ExecuteReader();
            while (dr.Read())
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = (int)dr.GetValue(0);
                dataGridView1.Rows[n].Cells[1].Value = dr.GetString(1);
               // dataGridView1.Rows[n].Cells[2].Value = dr.GetString(1);

            }
            dr.Close();

            //conn.Open();
            
            conn.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            comboBox2.Text = "";
            comboBox3.Text = "";
            textBox1.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            textBox2.Text = "";
        }

        private void Mark_Click(object sender, EventArgs e)
        {
            
            if((textBox2.Text != "" )  && comboBox2.Text != "" && dateTimePicker1.Value != null && textBox1.Text!="")
            {
                conn.Open();
                //int id;
                string h = string.Format("Select Id from Evaluation Where Name=@Name and TotalMarks=@TotalMarks");
                SqlCommand command = new SqlCommand(h, conn);
                command.Parameters.Add(new SqlParameter("@Name", comboBox2.Text));
                command.Parameters.Add(new SqlParameter("@TotalMarks", Convert.ToInt16(comboBox3.Text)));
                int rows = (int)command.ExecuteScalar();



                string g = string.Format("Insert INTO [GroupEvaluation](GroupId, EvaluationId, ObtainedMarks, EvaluationDate) values('{0}', '{1}', '{2}', '{3}' )", Convert.ToInt16(textBox2.Text), rows , Convert.ToInt16(textBox1.Text), Convert.ToDateTime(dateTimePicker1.Value));
                SqlCommand command1 = new SqlCommand(g, conn);
                int r1 = command1.ExecuteNonQuery();
                if (r1 != 0)
                {
                    MessageBox.Show("Evaluation Marked");
                    conn.Close();
                    button1_Click( sender, e);
                    panel1.Hide();
                    
                }

            }
            else
            {
                MessageBox.Show("Invalid Data");
            }
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            //this.Close();
            panel1.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            conn.Open();

            int id6 = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["GroupId"].Value);
            textBox2.Text = Convert.ToString(id6);
            SqlCommand da1 = new SqlCommand("Select TotalMarks, Name from [Evaluation] EXCEPT Select B.TotalMarks, B.Name from [GroupEvaluation] A INNER JOIN [Evaluation] B ON A.EvaluationId = B.Id where A.GroupId=@GroupId", conn);
            //SqlCommand command = new SqlCommand(h, conn);
            da1.Parameters.Add(new SqlParameter("@GroupId", id6));
            //int rows = (int)da1.ExecuteScalar();
            comboBox3.Items.Clear();
            comboBox2.Items.Clear();
            dr = da1.ExecuteReader();
            while (dr.Read())
            {
                int id = Convert.ToInt32(dr.GetValue(0));
                string id1 = dr.GetString(1);
                comboBox3.Items.Add(id);
                comboBox2.Items.Add(id1);

            }
            dr.Close();
            conn.Close();
            panel1.Show();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
    }
