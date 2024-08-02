using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Data
{
    public class Connection
    {

        private SqlConnection _connection = new SqlConnection(@"Data Source=DESKTOP-U6NIURD;Initial Catalog=Alquiler;Integrated Security=True;Encrypt=False");
        public SqlConnection OpenConnection()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
            return _connection;
        }

        //recordando momentos 2024 ciclo II//
        public SqlConnection CloseConnection()
        {
            if (_connection.State == ConnectionState.Open)
            {
                _connection.Close();
            }
            return _connection;
        }

    }
}
