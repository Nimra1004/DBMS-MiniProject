using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProject
{
    class DatabaseConnection
    {
        private static DatabaseConnection instance;
        private String ConnectionString = "Data Source=DESKTOP-1NUCU7V\\SQLEXPRESS;Initial Catalog=ProjectA;Integrated Security=True";
        private SqlConnection connection = new SqlConnection("Data Source=DESKTOP-1NUCU7V\\SQLEXPRESS;Initial Catalog=ProjectA;Integrated Security=True");

        public SqlConnection get_Connection_value()
        {
            return connection;
        }
        public string ConnectionString_value()
        {
            return ConnectionString;
        }


        public static DatabaseConnection getInstance()
        {
            if (instance == null)
                instance = new DatabaseConnection();
            return instance;
        }

        private DatabaseConnection()
        {
           
        }

        public SqlConnection getConnection()
        {
            //Connection = new SqlConnection(ConnectionString);
            if (connection.State != System.Data.ConnectionState.Open)
                connection.Open();
            return connection;
        }

        public SqlDataReader getData(String commnadText)
        {
            connection = getConnection();
            SqlCommand cmd = new SqlCommand(commnadText,connection);
            SqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }

        public int exectuteQuery(String commnadText)
        {
            connection = getConnection();
            SqlCommand cmd = new SqlCommand(commnadText,connection);
            int rows = cmd.ExecuteNonQuery();
            return rows;
        }

        public void closeConnection()
        {
            if (connection != null)
                connection.Close();
        }

    }
}
