using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace TimeTable.Data
{
    public class DatabaseConnection
    {
        private static class DbConnection
        {
            public static string ConnectionString = "Host=localhost;Port=5432;Database=TimeTable;Username=postgres;Password=Ek002";
        }

        // INSERT / UPDATE / DELETE
        public static async Task ExecuteSQLAsync(string SQL)
        {
            using (var conn = new NpgsqlConnection(DbConnection.ConnectionString))
            {
                await conn.OpenAsync();
                using (var cmd = new NpgsqlCommand(SQL, conn))
                {
                    await cmd.ExecuteNonQueryAsync();
                }
            }
        }

        // SELECT
        public static List<Dictionary<string, object>> Reader(string SQL)
        {
            var result = new List<Dictionary<string, object>>();

            using (var conn = new NpgsqlConnection(DbConnection.ConnectionString))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(SQL, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var row = new Dictionary<string, object>();
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            row[reader.GetName(i)] = reader.GetValue(i);
                        }
                        result.Add(row);
                    }
                }
            }

            return result;
        }
    }

}
