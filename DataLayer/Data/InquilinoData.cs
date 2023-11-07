using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommonLayer.Entities;

namespace DataLayer.Data
{
    public class InquilinoData
    {
            Connection _connection = new Connection();
            SqlDataReader _readerRows;
            SqlCommand _sqlcommand = new SqlCommand();
            DataTable inquilinosTable = new DataTable();

            public DataTable GetAllInquilinos()
            {
                _sqlcommand.Connection = _connection.OpenConnection();
                _sqlcommand.CommandText = "SELECT * FROM Inquilinos";
                _sqlcommand.CommandType = CommandType.Text;


                _readerRows = _sqlcommand.ExecuteReader();
                inquilinosTable.Load(_readerRows);

                _connection.CloseConnection();

                return inquilinosTable;
            }

            public void AddInquilino(Inquilino inquilino)
            {
                _sqlcommand.Connection = _connection.OpenConnection();
                _sqlcommand.CommandText = "INSERT INTO Inquilinos(Nombre, Email, Telefono, Direccion)"
                    + " VALUES(@Nombre, @Email, @Telefono, @Direccion)";

                _sqlcommand.Parameters.AddWithValue("@Nombre", inquilino.Nombre);
                _sqlcommand.Parameters.AddWithValue("@Email", inquilino.Email);
                _sqlcommand.Parameters.AddWithValue("@Telefono", inquilino.Telefono);
                _sqlcommand.Parameters.AddWithValue("@Direccion", inquilino.Direccion);

                _sqlcommand.ExecuteNonQuery();
                _sqlcommand.Parameters.Clear();
                _connection.CloseConnection();


            }
            public void UpdateInquilino(Inquilino inquilino)
            {
                _sqlcommand.Connection = _connection.OpenConnection();
                _sqlcommand.CommandText = "UPDATE Inquilinos "
                    + "SET Nombre = @Nombre, Email = @Email, Telefono = @Telefono, Direccion = @Direccion"
                    + " WHERE InquilinoId = @InquilinoId";
                _sqlcommand.CommandType = CommandType.Text;

                _sqlcommand.Parameters.AddWithValue("@Nombre", inquilino.Nombre);
                _sqlcommand.Parameters.AddWithValue("@Email", inquilino.Email);
                _sqlcommand.Parameters.AddWithValue("@Telefono", inquilino.Telefono);
                _sqlcommand.Parameters.AddWithValue("@Direccion", inquilino.Direccion);
                _sqlcommand.Parameters.AddWithValue("@InquilinoId", inquilino.Id);

                _sqlcommand.ExecuteNonQuery();
                _sqlcommand.Parameters.Clear();
                _connection.CloseConnection();

            }
            public void DeleteInquilino(Inquilino inquilino)
            {
                _sqlcommand.Connection = _connection.OpenConnection();
                _sqlcommand.CommandText = "DELETE  FROM Inquilinos WHERE InquilinoId = @Id";
                _sqlcommand.CommandType = CommandType.Text;

                _sqlcommand.Parameters.AddWithValue("@Id", inquilino.Id);

                _sqlcommand.ExecuteNonQuery();
                _sqlcommand.Parameters.Clear();
                _connection.CloseConnection();

            }
     }
}
