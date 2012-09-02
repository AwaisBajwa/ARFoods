using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.IO;
using System.Windows;

namespace ARFoods
{
    public class DB
    {
        private static SqlConnection _connection;
        public static SqlConnection Connection
        {
            get
            {
                if (_connection.State == System.Data.ConnectionState.Closed)
                {
                    _connection.Open();
                }
                return _connection;
            }
            
            set
            {
                _connection = value;
            }
            
        }

        public static string dataSource;
        public static string initialCatalog;
        public static string userID;
        public static string password;

        

        static DB()
        {
            try
            {
                connect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "DB Error", MessageBoxButton.OK, MessageBoxImage.Error);
                System.Windows.Application.Current.Shutdown();
            }
        }


        public static void connect()
        {
            Connection = new SqlConnection(getConnectionString());
        }

        public static string getConnectionString()
        {
            FileInfo configFile = new FileInfo("config.txt");

            FileStream fStream = configFile.OpenRead();

            StreamReader reader = new StreamReader(fStream);

            try
            {
                
                dataSource = reader.ReadLine();
                initialCatalog = reader.ReadLine();
                userID = reader.ReadLine();
                password = reader.ReadLine();

                string connectionString = "";

                if (string.IsNullOrEmpty(userID))
                {
                    connectionString = "Data Source =" + dataSource + ";Initial Catalog=" + initialCatalog +
                    ";Integrated Security = true";
                }
                else
                {
                    connectionString = "Data Source =" + dataSource + ";Initial Catalog=" + initialCatalog +
                    ";User Id=" + userID + ";Password =" + password + ";"; 
                }

                return connectionString;
            
            }
            catch (Exception)
            {
                System.Windows.Application.Current.Shutdown();
            }

            return null;
        }

    }
}
