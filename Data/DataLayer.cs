using Npgsql;


namespace TimeTable.Data
{
    public class DataLayer
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
        public static void GetUserID()
        {
            string sql = $@"SELECT user_id From users where username = @username";
            Reader(sql);
        }

        public static void CreatUser()
        {
            string sql = @"CREATE user";
        }

        public static void GetHashedPasswordFromDatabse()
        {
            string sql = @"
                SELECT u.user_id, u.username, up.hashed_password
                FROM Users u
                INNER JOIN UserPasswords up ON u.user_id = up.user_id
                WHERE u.username = @username";
        }

        public static void GetTasksFromDatabase()
        {
            string sql = $@"SELECT task_id, description, priority, estimated_min FROM tasks WHERE completed = false AND DueDate >= {TimeOnly.FromDateTime(DateTime.Now)}";
        }


    }
}
