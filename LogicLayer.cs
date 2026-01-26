using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;

namespace TimeTable
{
    internal class LogicLayer
    {

        public void HashPassword(string password)
        {
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password, 12);
        }

        public void VerifyPassowrd(string password)
        {
            
        }
    }
}
