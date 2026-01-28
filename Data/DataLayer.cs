using Npgsql;
using System.Diagnostics;

namespace TimeTable.Data
{
    internal class DataLayer
    {
        
        public static void Verify()
        {
            string SQL = @"SELECT hashed_password FROM UserPasswords, User JOIN Where Users.user_id = UserPasswords.user_id AND ";
        }
    }
}
