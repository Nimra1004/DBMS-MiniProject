using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProject
{
    class Project
    {
        private string Description;
        private string Title;
        //private DateTime DateofBirth;

        public Project()
        {
            Description = null;
            Title = null;
        }

        public string Get_Description()
        { 
            return Description;
        }

        public void set_Description(string val)
        {
            if (val != "")
            {
                Description = val;
            }
        }

        public string Get_Title()
        {
            return Title;
        }

        public void set_Title(string val)
        {
            if (val != "")
            {
                Title = val;

            }
        }
    }

}
