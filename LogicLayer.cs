using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTable
{
    internal class LogicLayer
    {

        public void HashPassword(string username, string password)
        {
            string usernamePassword = username + password;
            // get salt form username and passowrd 
            for (int i = 0; i < password.Length; i++)
            {
                GenrateSalt(usernamePassword);
            }
            // add salt to username password

            // output hash string

        }

        public int GenrateSalt(string usernamePassword)
        {   
            
            int salt = 0;
            for (int i = 0; i < usernamePassword.Length / 2; i++)
            {
                salt += Convert.ToInt32(usernamePassword[i]) * i;
            }

            return salt;
        }

        public bool ValidatePassowrd(string password)
        {   
            bool containsUpper = false; // check if password contains at least 1 Upper case
            foreach (char c in password)
            {
                if (char.IsUpper(c))
                {
                    containsUpper = true;
                    break;
                }
            }
            if (!containsUpper)
            {
                return false;
            }

            bool containsNumber = false; // check if password contains at least 1 number
            foreach (char c in password)
            {
                if (char.IsDigit(c))
                {
                    containsNumber = true;
                    break;
                }
            }
            if (!containsNumber)
            {
                return false;
            }


            if (string.IsNullOrEmpty(password)) // check if password is empty
            {
                return false;
            }
            else if (password.Length < 8 || password.Length > 16) // check if password length is between 8 and 16
            {
                return false;
            }
            else
            {
                return true;
            }


        }
    }

    class signUP()
    {

    }

}
