using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data.Common;

namespace LastNa
{
    internal class databaseConnection
    {
        public MySqlConnection connection;

        private string server;
        private string database;
        private string uid;
        private string password;

        public databaseConnection()
        {
            Initialize();
        }

        private void Initialize()
        {

            server = "localhost";
            database = "future_company";
            uid = "root";
            password = "padabakonggf";

            string connectionString = $"SERVER={server};DATABASE={database};UID={uid};PASSWORD={password};";
            connection = new MySqlConnection(connectionString);
        }

        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
