using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Organization_of_practical_training_for_students
{
    internal class db
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=;database=cursovayabdinsubd");

        public void OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }

        public void ClosedConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        public MySqlConnection getConnection()
        {
            return connection;

        }

        internal void CloseConnection()
        {
            throw new NotImplementedException();
        }
    }
}
