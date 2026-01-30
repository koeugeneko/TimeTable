using Npgsql;
using System.Diagnostics;

namespace TimeTable.Data
{
    public class DataLayer
    {
        public static void GetUserID()
        {
            string sql = $@"SELECT user_id From users where username = @username";
            DatabaseConnection.Reader(sql);
        }

        public static void CreatUser()
        {
            string sql = @"SELECT"
        }

        public static void GetHashedPasswordFromDatabse()
        {
            string sql = @"SELECT hashed_password FROM UserPasswords, User JOIN Where Users.user_id = UserPasswords.user_id AND "; //TODO
        }

        public static List<Task> GetTasksFromDatabase()
        {
            string sql = $@"SELECT task_id, description, priority, estimated_min FROM tasks WHERE completed = false AND DueDate >= {TimeOnly.FromDateTime(DateTime.Now)}";
        }


    }
}
