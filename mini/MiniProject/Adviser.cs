using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProject
{
    class Adviser
    {
        private string Designation;
        private decimal Salary;
        private string FirstName;
        private string LastName;
        private DateTime DateofBirth;
        private string Gender;
        private string Contact;
        private string Email;
        public Adviser()
        {
            Designation = null;
            Salary = decimal.Zero;
            FirstName = null;
            LastName = null;
            DateofBirth = DateTime.MinValue;
            Contact = null;
            Email = null;
            Gender = null;
        }
        ///<summary>
        /// Gets the value for name after checking for validations
        /// </summary>
        /// <param name="value">
        /// </param>
        public string Get_First_Name()
        {
            string First_Name = FirstName;
            return First_Name;
        }
        /// <return>
        /// Returns Student Name String
        /// </return>

        ///<summary>
        /// Sets the value for name after checking for validations
        /// </summary>
        /// <param name="value">
        /// </param>

        public void set_First_Name(string val)
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
                FirstName = val;
            }
            else
            {
                //MessageBox.Show("wrong First Name");
            }
        }
        public string Get_Last_Name()
        {
            string Last_Name = LastName;
            return Last_Name;
        }
        /// <return>
        /// Returns Student Name String
        /// </return>
        public void set_Last_Name(string val)
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
                    LastName = val;
                }
                else
                {
                    //MessageBox.Show("wrong Last Name");
                }
            }
        }
        public string Get_Contact()
        {
            string contact = Contact;
            return contact;
        }
        public void set_Contact(string val)
        {
            if (val != "")
            {
                int i = val.Length;
                bool f = false;
                if (i == 11)
                {
                    for (int j = 0; j < i; j++)
                    {
                        if (!char.IsDigit(val[j]))
                        {
                            f = true;
                        }
                    }
                    if (val[0] == '0' && val[1] == '3')
                    {
                        if (f == true)
                        {
                            //MessageBox.Show("Only Digits are allowed");
                            return;
                        }
                        else
                        {
                            Contact = val;
                        }
                    }
                    else
                    {
                        //MessageBox.Show("Please Write an 11 digits Contact Number");
                    }
                }
            }
        }
        public string Get_Email()
        {
            string email = Email;
            return email;
        }
        public void set_Email(string val)
        {
            bool isValid = false;
            if (!string.IsNullOrWhiteSpace(val))
            {
                Regex reg = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
                if (!reg.IsMatch(val))
                {
                    isValid = true;
                    //MessageBox.Show("Please Write a Valid Email Address");
                    return;
                }
                else
                {
                    Email = val;
                }
            }


        }
        public string Get_Gender()
        {
            string gender = Gender;
            return gender;
        }
        public void set_Gender(string val)
        {
            if (val != "")
            {
                if (val == "Female" || val == "Male")
                {
                    Gender = val;
                }
                else
                {
                    //MessageBox.Show("Please Write Male OR Female");
                }
            }
        }
        public DateTime Get_DOB()
        {
            DateTime dob = DateofBirth;
            return dob;
        }
        public void set_DOB(DateTime val)
        {
            DateofBirth = val;
            /**
            DateTime dt;
            bool success = DateTime.TryParse(val, out dt);
            if(success == true)
            {
                DateofBirth = Convert.ToDateTime(val);
            }
            else
            {
                MessageBox.Show("Please Write in yyyy/mm/dd Format");
            }
    **/
        }
        public string Get_Designation()
        {
            return Designation;
        }
        public decimal Get_Salary()
        {
            return Salary;
        }
        public void set_Designation(string val)
        {
            Designation = val;
        }
        public void set_Salary(string val)
        {
            if (val != "")
            {
                Salary = Convert.ToDecimal(val);
            }
        }
    }
}
