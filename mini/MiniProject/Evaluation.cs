using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProject
{
    class Evaluation
    {
        private string Name;
        private int Total_Marks;
        private int Total_Weitage;

        public Evaluation()
        {
            Name = "";
            Total_Marks = 0;
            Total_Weitage = 0;

        }

        public string Get_Name()
        {
            return Name;
        }
        public int Get_Total_Marks()
        {
            return Total_Marks;
        }
        public int Get_Total_Weitage()
        {
            return Total_Weitage;
        }

        public void set_Name(string val)
        {
            if (val != "")
            {
                int i = 0;
                foreach (char c in val)
                {

                    if (!char.IsLetter(c) && !char.IsWhiteSpace(c))
                    {
                        i = 1;
                    }
                }
                if (i == 0)
                {
                    Name = val;
                }
                else
                {
                    MessageBox.Show("Invalid Name");
                }
            }
        }

        public void set_Total_Marks(string val)
        {
            if (val != "")
            {
                bool f = false;
                foreach (char c in val)
                {
                    if (!char.IsDigit(c))
                    {
                        f = true;
                    }
                }
                if (f == true)
                {
                    MessageBox.Show("Invalid Total Marks");
                }
                else
                {
                    Total_Marks = Convert.ToInt32(val);
                }
            }

        }

        public void set_Total_Weitage(string val1)
        {
            if (val1 != "")
            {
                bool f = false;
                foreach (char c in val1)
                {
                    if (!char.IsDigit(c))
                    {
                        f = true;
                    }
                }
                if (f == true)
                {
                    MessageBox.Show("Invalid Total Weitage");
                }
                else
                {
                    Total_Weitage = Convert.ToInt32(val1);
                }
            }

        }
    }
}
