using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;

namespace DataLayer.Data
{
    public class AuthData
    {

        Connection _connection = new Connection();
        SqlCommand _sqlCommand = new SqlCommand();
        SqlDataReader _readerRows;

        public bool Login(string name, string password)
        {
            _sqlCommand.Connection = _connection.OpenConnection();
            _sqlCommand.CommandText = "SELECT * FROM Users WHERE userName = @nameLogin AND password = @password;";
            _sqlCommand.Parameters.AddWithValue("@nameLogin", name);
            _sqlCommand.Parameters.AddWithValue("@password", password);
            _sqlCommand.CommandType = CommandType.Text;

            _readerRows = _sqlCommand.ExecuteReader();

            if (_readerRows.HasRows)
            {
                _readerRows.Close();
                _readerRows.Dispose();
                _connection.CloseConnection();

                return true;
            }
            else
            {
                return false;
            }
        }

        public int Register(string name, string email, string password)
        {
            _sqlCommand.Connection = _connection.OpenConnection();
            _sqlCommand.CommandText = "INSERT INTO Users " +
                " VALUES(@nameRegister, @password, @email)";

            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

            _sqlCommand.Parameters.AddWithValue("@nameRegister", name);
            _sqlCommand.Parameters.AddWithValue("@email", email);
            SqlParameter sqlParameter = _sqlCommand.Parameters.AddWithValue("@password", hashedPassword);
            _sqlCommand.CommandType = CommandType.Text;

            var rowsAffected = _sqlCommand.ExecuteNonQuery();
            _sqlCommand.Parameters.Clear();
            _connection.CloseConnection();

            return rowsAffected;
        }

        public string GetPasswordByUserName(string name)
        {
            _sqlCommand.Connection = _connection.OpenConnection();
            _sqlCommand.CommandText = "SELECT * FROM Users WHERE userName = @name;";
            _sqlCommand.Parameters.AddWithValue("@name", name);
            _sqlCommand.CommandType = CommandType.Text;

            _readerRows = _sqlCommand.ExecuteReader();

            string password = "";

            if (_readerRows.Read() == true)
            {
                try
                {
                    password = _readerRows.GetString(2);
                }
                catch (Exception ex)
                {
                    string error = ex.Message;
                }
            }

            _readerRows.Close();
            _readerRows.Dispose();
            _connection.CloseConnection();

            return password;
        }

    }
}
