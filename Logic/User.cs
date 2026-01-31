using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTable.Logic
{
    public class User
    {
        public string username { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        int userId { get; set; }

        public User(string username, string password)
        {
            this.username = username;
            this.password = password;
        }

        //userId = 
        
    }
}
