using MySql.Data.MySqlClient;

namespace DAL
{
    public class DBConnect
    {
        public static string SERVER_NAME= "127.0.0.1";
        public static string DATABASE_NAME = "quanlythuvien";
        public static string USERNAME = "root";
        public static string PASSWORD = "root";
        public static string connectionString=$"Server={SERVER_NAME};Database={DATABASE_NAME};User Id={USERNAME};password={PASSWORD};";
        protected MySqlConnection _conn = new MySqlConnection(connectionString);
    }
}
