using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTable.Logic
{
    internal class AuthService
    {
        public bool ValidatePassowrd(string password)
        {
            if (string.IsNullOrEmpty(password)) // check if password is empty
            {
                return false;
            }
            else if (password.Length < 8 || password.Length > 16) // check if password length is between 8 and 16
            {
                return false;
            }

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

            return true;
        }

        public bool ValidateUsername(string username)
        {
            if (string.IsNullOrEmpty(username)) // check if username is empty
            {
                return false;
            }
            else if (username.Length < 6 || username.Length > 50) // check if username length is between 5 and 12
            {
                return false;
            }
            return true;
        }
        
        public void HashPassword(string username, string password)
        {
            string plaintext = username + password;

            // get salt form username and passowrd 
            for (int i = 0; i < password.Length / 2; i++) // run the genrate salt with password length/2 times
            {
                plaintext = GenrateSalt(plaintext);
            }
            // add salt to username password


            // convert to hex
            // output hash string

        }

        public string GenrateSalt(string plaintext)
        {

            int salt = 0;
            for (int i = 0; i < plaintext.Length; i++) // salt = ASCII * posision
            {
                salt += Convert.ToInt32(plaintext[i]) * i;
            }

            return Convert.ToString(salt);
        }
        
    }
}
