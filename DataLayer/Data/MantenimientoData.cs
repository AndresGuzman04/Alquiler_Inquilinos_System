using CommonLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Data
{
    public class MantenimientoData
    {

        Connection _connection = new Connection();
        SqlDataReader _readerRows;
        SqlCommand _sqlCommand = new SqlCommand();
        DataTable mantenimentosTable = new DataTable();

        public DataTable GetAllMantenimientos()
        {
            _sqlCommand.Connection = _connection.OpenConnection();
            _sqlCommand.CommandText =   "SELECT Mantenimiento.MantenimientoID AS ID, Mantenimiento.FechaMantenimiento AS Fecha," +
                " Mantenimiento.Descripcion, Mantenimiento.Costo, Propiedades.Nombre AS Propiedad" +
                " FROM Mantenimiento INNER JOIN Propiedades ON Propiedades.PropiedadID = Mantenimiento.PropiedadID;";
            _sqlCommand.CommandType = CommandType.Text;

            _readerRows = _sqlCommand.ExecuteReader();
            mantenimentosTable.Load(_readerRows);

            _connection.CloseConnection();

            return mantenimentosTable;
        }

        public void AddMantenimiento(Mantenimiento mantenimiento)
        {

            _sqlCommand.Connection = _connection.OpenConnection();
            _sqlCommand.CommandText = "INSERT INTO Mantenimiento(FechaMantenimiento, Descripcion, Costo, PropiedadID)"
                + "VALUES(@FechaMantenimiento, @Descripcion, @Costo, @PropiedadID)";
            
            _sqlCommand.Parameters.AddWithValue("@FechaMantenimiento", mantenimiento.fechaMantenimiento);
            _sqlCommand.Parameters.AddWithValue("@Descripcion", mantenimiento.descripcion);
            _sqlCommand.Parameters.AddWithValue("@Costo", mantenimiento.costo);
            _sqlCommand.Parameters.AddWithValue("@PropiedadID", mantenimiento.propiedadId);

            _sqlCommand.ExecuteNonQuery();
            _sqlCommand.Parameters.Clear();

            _connection.CloseConnection();

        }

        public void UpdateMantenimiento(Mantenimiento mantenimiento)
        {

            _sqlCommand.Connection = _connection.OpenConnection();
            _sqlCommand.CommandText = "UPDATE Mantenimiento"
                + " SET FechaMantenimiento = @FechaMantenimiento, Descripcion = @Descripcion,"
                + "Costo = @Costo, PropiedadID = @PropiedadID"
                + " WHERE MantenimientoID = @Id";

            _sqlCommand.Parameters.AddWithValue("@Id", mantenimiento.id);
            _sqlCommand.Parameters.AddWithValue("@FechaMantenimiento", mantenimiento.fechaMantenimiento);
            _sqlCommand.Parameters.AddWithValue("@Descripcion", mantenimiento.descripcion);
            _sqlCommand.Parameters.AddWithValue("@Costo", mantenimiento.costo);
            _sqlCommand.Parameters.AddWithValue("@PropiedadID", mantenimiento.propiedadId);

            _sqlCommand.ExecuteNonQuery();
            _sqlCommand.Parameters.Clear();

            _connection.CloseConnection();

        }

        public void DeleteMantenimiento(Mantenimiento mantenimiento)
        {

            _sqlCommand.Connection = _connection.OpenConnection();
            _sqlCommand.CommandText = "DELETE FROM Mantenimiento WHERE MantenimientoID = @Id";

            _sqlCommand.Parameters.AddWithValue("@Id", mantenimiento.id);

            _sqlCommand.ExecuteNonQuery();
            _sqlCommand.Parameters.Clear();

            _connection.CloseConnection();

        }

    }
}
