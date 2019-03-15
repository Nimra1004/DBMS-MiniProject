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
    public partial class Eval_Dashboards : Form
    {
        SqlConnection conn = DatabaseConnection.getInstance().getConnection();
        
        public Eval_Dashboards()
        {
            InitializeComponent();
            Edit_Panel.Hide();
            try
            {
                SqlCommand cm = new SqlCommand("Select Id, Name, TotalMarks, TotalWeightage From Evaluation ", conn);
                SqlDataReader dr;
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = (int)dr.GetValue(0);
                    dataGridView1.Rows[n].Cells[1].Value = dr.GetString(1);
                    dataGridView1.Rows[n].Cells[2].Value = dr.GetValue(2);
                    dataGridView1.Rows[n].Cells[3].Value = dr.GetValue(3);
                };
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void AddEvaluationIcon_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            conn.Open();
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete" && (e.RowIndex >= 0))
            {
                try
                {
                    if (MessageBox.Show("Are You Sure You Want to Delete this?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);
                        string m = String.Format("DELETE FROM Evaluation Where Id = @Id ");
                        SqlCommand command = new SqlCommand(m, conn);
                        command.Parameters.Add(new SqlParameter("@Id", id));
                        int rows = command.ExecuteNonQuery();
                        if (rows != 0)
                        {
                            MessageBox.Show("Data deleted!");
                            this.Hide();
                            Eval_Dashboards D = new Eval_Dashboards();
                            D.Show();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                conn.Close();
            }
            

            else if (dataGridView1.Columns[e.ColumnIndex].Name == "Edit" && (e.RowIndex >= 0))
            {
                if (MessageBox.Show("Are You Sure You Want to Update this?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    Edit_Panel.Show();
                    conn.Open();
                    int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["Id"].Value);
                    SqlCommand cm = new SqlCommand("Select Id, Name, TotalMarks, TotalWeightage from Evaluation  where Id=@Id ", conn);
                    cm.Parameters.Add(new SqlParameter("@Id", id));
                    SqlDataReader dr;
                    dr = cm.ExecuteReader();
                    try
                    {
                        while (dr.Read())
                        {
                            nametxt.Text = dr.GetString(1);
                            markstxt.Text = Convert.ToString(dr.GetValue(2));
                            Weightaetxt.Text = Convert.ToString(dr.GetValue(3));
                            textBox1.Text = Convert.ToString(dr.GetValue(0));
                        }
                        dr.Close();
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    
                }
                conn.Close();
            }
            else
            {
                MessageBox.Show("No Data");
            }
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            conn.Open();
            Evaluation C1 = new Evaluation();
            C1.set_Name(nametxt.Text);
            C1.set_Total_Marks(markstxt.Text);
            C1.set_Total_Weitage(Weightaetxt.Text);
            if ((C1.Get_Name() != null) && (C1.Get_Total_Marks() != 0) && (C1.Get_Total_Weitage() != 0))
            {
                try
                {
                    int ID = Convert.ToInt32(textBox1.Text);
                    string cmd2 = String.Format("UPDATE Evaluation SET Name = @Name, TotalMarks=@TotalMarks, TotalWeightage=@TotalWeightage Where Id = @Id ");
                    SqlCommand command2 = new SqlCommand(cmd2, conn);
                    command2.Parameters.Add(new SqlParameter("@Id", ID));

                    command2.Parameters.Add(new SqlParameter("@TotalWeightage", SqlDbType.Int));
                    command2.Parameters["@TotalWeightage"].Value = C1.Get_Total_Weitage();
                    command2.Parameters.Add(new SqlParameter("@Name", SqlDbType.VarChar));
                    command2.Parameters["@Name"].Value = C1.Get_Name();
                    command2.Parameters.Add(new SqlParameter("@TotalMarks", SqlDbType.Int));
                    command2.Parameters["@TotalMarks"].Value = C1.Get_Total_Marks();


                    int rows2 = command2.ExecuteNonQuery();
                    if (rows2 != 0)
                    {
                        MessageBox.Show("Evaluations Details Updated");
                        conn.Close();
                        Edit_Panel.Hide();
                        this.Hide();
                        Eval_Dashboards D = new Eval_Dashboards();
                        D.Show();
                        

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

        private void Cancel_Click(object sender, EventArgs e)
        {
            nametxt.Text = " ";
            markstxt.Text = " ";
            Weightaetxt.Text = " ";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Edit_Panel.Hide();
        }

        private void Eval_Dashboards_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Edit_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Edit_Panel.Hide();
        }

        private void AddEvaluationIcon_Click_1(object sender, EventArgs e)
        {
            this.Close();
            AddEvaluation p1 = new AddEvaluation();
            p1.Show();
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
