using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TimeTable.Logic
{
    internal class AuthService
    {
        

        public bool ValidateUsername(string username)
        {
            if (string.IsNullOrEmpty(username)) return false; // check if username is empty

            string pattern = @"^[A-Za-z0-9_]{6,50}$";
            return Regex.IsMatch(username, pattern);

            /*else if (username.Length < 6 || username.Length > 50) // check if username length is between 5 and 12
            {
                return false;
            }
            return true;*/
        }
        public bool ValidateEmail(string email)
        {
            string pattern = @"^[\w\.-]+@[\w\.-]+\.\w+$";
            return Regex.IsMatch(email, pattern);
        }

        public bool ValidatePassowrd(string password)
        {
            if (string.IsNullOrEmpty(password)) return false; // check if password is empty

            string pattern = @"^(?=.*[A-Z])(?=.*\d)[A-Za-z\d!@#$%^&*]{8,16}$";
            return Regex.IsMatch(password, pattern);

            /*else if (password.Length < 8 || password.Length > 16) // check if password length is between 8 and 16
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

            return true;*/
        }
        public void HashPassword(string password)
        {
            int saltLength = 16;
            byte[] salt = new byte[saltLength];


            // get salt form username and passowrd 
            for (int i = 0; i < password.Length / 2; i++) // run the genrate salt with password length/2 times
            {
            }
            // add salt to username password


            // convert to hex
            // output hash string

        }

        public string GenerateSalt(int saltLength)
        {
            var rng = new Random();
            char[] chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789".ToCharArray();
            char[] salt = new char[saltLength];
            for (int i = 0; i < saltLength; i++)
                salt[i] = chars[rng.Next(chars.Length)];
            return new string(salt);
        }

    }
}
