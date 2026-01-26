using Npgsql;
using System.Diagnostics;

namespace TimeTable
{
    internal class DataLayer
    {
        private static class DbConnection
        {
            public static string ConnectionString = "Host=localhost;Port=5432;Database=TimeTable;Username=postgres;Password=Ek002";

        }

        public static void ConnectDB(string SQL)
        {
            var conn = new NpgsqlConnection(DbConnection.ConnectionString); // create a connection object
            string text = "Hello, World!";
            conn.Open(); // open the connection
            var cmd = new NpgsqlCommand(SQL, conn); // encapsulate the sql string to connection

            cmd.Parameters.AddWithValue("@text", text);

            cmd.ExecuteNonQueryAsync(); // execute the sql command
            conn.Close();

        }

        public static void Verify()
        {
            String SQL = @"SELECT hashed_password FROM UserPasswords, User JOIN Where Users.user_id = UserPasswords.user_id AND ";
        }
    }
}
