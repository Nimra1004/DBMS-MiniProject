using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProject
{
    class Student
    {
        // Data Members
        private string FirstName;
        private string LastName;
        private DateTime DateofBirth;
        private string Gender;
        private string Contact;
        private string Email;
        private string RegistrationNo;



        /// <summary>
        /// Default Constructor
        /// </summary>
        public Student()
        {
            FirstName = null;
            LastName = null;
            RegistrationNo = null;
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
            
        }

        /// <summary>
        /// This function gets the Student Registration Number from the Object
        /// </summary>
        /// /// <summary>
        /// This function gets the Student Registration Number from the Object
        /// </summary>
        /// 

        /// 
        /// Sets the value for name after checking for validations
        /// </summary>
        /// <param name="value">
        /// </param>
        ///<summary>
        /// Gets the value for name after checking for validations
        /// </summary>
        /// <param name="value">
        /// </param>
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
            
        }

        /// <summary>
        /// This function gets the Student Registration Number from the Object
        /// </summary>
        /// /// <summary>
        /// This function gets the Student Registration Number from the Object
        /// </summary>

        ///<Param>
        /// No Parameters for getters
        ///</Param>

        //getter for Registration Number
        public string Get_Reg_No()
        {
            return RegistrationNo;
        }
        /// <return>
        /// returns Registration number string
        /// </return>

        ///<summary>
        ///Setter Function that sets the roll no
        /// </summary>
        /// <param name="roll_no"></param>
        //setter
        public void set_Reg_No(string val)
        {
            int i = val.Length;
            
            if (i == 11)
            {
                bool f = false;
                if (f == false)
                {
                    int a = 0;
                    for (a = 0; a < 4; a++)
                    {
                        if (!char.IsDigit(val[a]))
                        {
                            f = true;
                        }

                    }
                    if (f == true)
                    {
                       // MessageBox.Show("Only digits are allowed in first four places. --Wrong registration number-- ");
                    }
                    int b = 4;
                    f = false;
                    if (!(val[b] == '-'))
                    {
                        f = true;
                    }
                    if (f == true)
                    {
                        //MessageBox.Show("Only - is allowed here. --Wrong registration number-- ");
                    }
                    f = false;
                    int c = 5;
                    for (c = 5; c < 7; c++)
                    {
                        if (!Char.IsLetter(val[c]))
                        {
                            f = true;
                        }
                    }
                    if (f == true)
                    {
                        //MessageBox.Show("Only letters are allowed here. --Wrong registration number-- ");
                    }
                    int d = 7;
                    f = false;
                    if (!(val[d] == '-'))
                    {
                        f = true;
                    }
                    if (f == true)
                    {
                        //MessageBox.Show("Only - is allowed here. --Wrong registration number-- ");
                    }
                    int e = 8;
                    f = false;
                    for (e = 8; e < 11; e++)
                    {
                        if (!Char.IsDigit(val[e]))
                        {
                            f = true;
                        }
                    }
                    if (f == true)
                    {
                        //MessageBox.Show("Only digits are allowed here. --Wrong registration number-- ");
                    }
                }
                if (f == false)
                {
                    RegistrationNo = val;

                    return;
                }
                else
                {
                   // MessageBox.Show("PLease Write According to this Format -- 2016-CE-067 OR 2016-CE-67 OR 2016-CE-7");
                }
            }
            if (i == 10)
            {
                bool f = false;
                if (f == false)
                {
                    int a = 0;
                    for (a = 0; a < 4; a++)
                    {
                        if (!char.IsDigit(val[a]))
                        {
                            f = true;
                        }

                    }
                    if (f == true)
                    {
                        //MessageBox.Show("Only digits are allowed in first four places. --Wrong registration number-- ");
                    }
                    int b = 4;
                    f = false;
                    if (!(val[b] == '-'))
                    {
                        f = true;
                    }
                    if (f == true)
                    {
                       // MessageBox.Show("Only - is allowed here. --Wrong registration number-- ");
                    }
                    f = false;
                    int c = 5;
                    for (c = 5; c < 7; c++)
                    {
                        if (!Char.IsLetter(val[c]))
                        {
                            f = true;
                        }
                    }
                    if (f == true)
                    {
                        //MessageBox.Show("Only letters are allowed here. --Wrong registration number-- ");
                    }
                    int d = 7;
                    f = false;
                    if (!(val[d] == '-'))
                    {
                        f = true;
                    }
                    if (f == true)
                    {
                       // MessageBox.Show("Only - is allowed here. --Wrong registration number-- ");
                    }
                    int e = 8;
                    f = false;
                    for (e = 8; e < 10; e++)
                    {
                        if (!Char.IsDigit(val[e]))
                        {
                            f = true;
                        }
                    }
                    if (f == true)
                    {
                       // MessageBox.Show("Only digits are allowed here. --Wrong registration number-- ");
                    }
                }
                if (f == false)
                {
                    RegistrationNo = val;
                    return;
                }
                else
                {
                    //MessageBox.Show("PLease Write According to this Format -- 2016-CE-067 OR 2016-CE-67");
                }
            }
            if (i == 9)
            {
                bool f = false;
                if (f == false)
                {
                    int a = 0;
                    for (a = 0; a < 4; a++)
                    {
                        if (!char.IsDigit(val[a]))
                        {
                            f = true;
                        }
                    }
                    if (f == true)
                    {
                        //MessageBox.Show("Only digits are allowed in first four places. --Wrong registration number-- ");
                    }
                    int b = 4;
                    f = false;
                    if (!(val[b] == '-'))
                    {
                        f = true;
                    }
                    if (f == true)
                    {
                        //MessageBox.Show("Only - is allowed here. --Wrong registration number-- ");
                    }
                    f = false;
                    int c = 5;
                    for (c = 5; c < 7; c++)
                    {
                        if (!Char.IsLetter(val[c]))
                        {
                            f = true;
                        }
                    }
                    if (f == true)
                    {
                       // MessageBox.Show("Only letters are allowed here. --Wrong registration number-- ");
                    }
                    int d = 7;
                    f = false;
                    if (!(val[d] == '-'))
                    {
                        f = true;
                    }
                    if (f == true)
                    {
                       // MessageBox.Show("Only - is allowed here. --Wrong registration number-- ");
                    }
                    int e = 8;
                    f = false;
                    for (e = 8; e < 9; e++)
                    {
                        if (!Char.IsDigit(val[e]))
                        {
                            f = true;
                        }
                    }
                    if (f == true)
                    {
                       // MessageBox.Show("Only digits are allowed here. --Wrong registration number-- ");
                    }
                }
                if (f == false)
                {
                    RegistrationNo = val;
                    return;
                }
                else
                {
                   // MessageBox.Show("PLease Write According to this Format -- 2016-CE-067 OR 2016-CE-67 OR 2016-CE-7");
                }
            }
            else
            {
                //MessageBox.Show("PLease Write According to this Format -- 2016-CE-067 OR 2016-CE-67 OR 2016-CE-7");
            }
        }
        public string Get_Contact()
        {
            string contact = Contact;
            return contact;
        }
        public void set_Contact(string val)
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
            if (val == "Female" || val == "Male")
            {
                Gender = val;
            }
            else
            {
                //MessageBox.Show("Please Write Male OR Female");
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

    }
}
