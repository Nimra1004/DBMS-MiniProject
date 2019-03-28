using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProject
{
    public partial class REport2 : Form
    {
        public REport2()
        {
            InitializeComponent();
        }

        private void REport2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'EvaluationDataset.DataTable1' table. You can move, or remove it, as needed.
            this.DataTable1TableAdapter.Fill(this.EvaluationDataset.DataTable1);

            this.reportViewer1.RefreshReport();
        }
    }
}
