using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeTable.Data
{
    internal class DatabaseConnection
    {
        private static class DbConnection
        {
            public static string ConnectionString = "Host=localhost;Port=5432;Database=TimeTable;Username=postgres;Password=Ek002";
        }

        public static void ConnectDB(string SQL)
        {
            var conn = new NpgsqlConnection(DbConnection.ConnectionString); // create a connection object
            conn.Open(); // open the connection
            var cmd = new NpgsqlCommand(SQL, conn); // encapsulate the sql string to connection

            cmd.ExecuteNonQueryAsync(); // execute the sql command
            conn.Close();

        }
    }
}
