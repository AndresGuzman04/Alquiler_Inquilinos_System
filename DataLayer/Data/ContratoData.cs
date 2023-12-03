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
    public class ContratoData
    {

        Connection _connection = new Connection();
        SqlDataReader _readerRows;
        SqlCommand _sqlcommand = new SqlCommand();
        DataTable contratosTable = new DataTable();

        public DataTable GetAllContratos()
        {
            _sqlcommand.Connection = _connection.OpenConnection();
            _sqlcommand.CommandText =   "SELECT Contratos.ContratoID AS ID, Contratos.FechaInicio AS Inicio, " +
                                        " Contratos.FechaFin AS Fin, Contratos.MontoMensual AS MontoMes, " +
                                        " Propiedades.Nombre AS Propiedad, Inquilinos.Nombre AS Inquilino " +
                                        " FROM Contratos INNER JOIN Inquilinos ON Inquilinos.InquilinoID = Contratos.InquilinoID " +
                                        " INNER JOIN Propiedades ON Propiedades.PropiedadID = Contratos.PropiedadID;";
            _sqlcommand.CommandType = CommandType.Text;


            _readerRows = _sqlcommand.ExecuteReader();
              contratosTable.Load(_readerRows);

            _connection.CloseConnection();

            return contratosTable;
        }
        public int GetInquilinoID(Contratos contratos)
        {
            int inquilinoID = 0;

            _sqlcommand.Connection = _connection.OpenConnection();
            _sqlcommand.CommandText = "SELECT InquilinoID FROM Contratos WHERE ContratoID = @contratoId;";
            _sqlcommand.CommandType = CommandType.Text;

            _sqlcommand.Parameters.AddWithValue("@contratoId", contratos.Id);

            object result = _sqlcommand.ExecuteScalar();

            if (result != null && int.TryParse(result.ToString(), out inquilinoID))
            {
            }
            else
            {

            }

            _connection.CloseConnection();

            return inquilinoID;
        }
        public int GetPropiedadID(Contratos contratos)
        {
            int propiedadID = 0;

            _sqlcommand.Connection = _connection.OpenConnection();
            _sqlcommand.CommandText = "SELECT PropiedadID FROM Contratos WHERE ContratoID = @contratosId;";
            _sqlcommand.CommandType = CommandType.Text;

            _sqlcommand.Parameters.AddWithValue("@contratosId", contratos.Id);

            object result = _sqlcommand.ExecuteScalar();

            if (result != null && int.TryParse(result.ToString(), out propiedadID))
            {
            }
            else
            {

            }

            _connection.CloseConnection();

            return propiedadID;
        }
        public void AddContrato(Contratos contratos)
        {
            _sqlcommand.Connection = _connection.OpenConnection();
            _sqlcommand.CommandText = "INSERT INTO Contratos(FechaInicio, FechaFin, MontoMensual, PropiedadID, InquilinoID)"
                + "VALUES(@FechaInicio, @FechaFin, @MontoMensual, @PropiedadID, @InquilinoID)";

            _sqlcommand.Parameters.AddWithValue("@FechaInicio", contratos.FechaInicio);
            _sqlcommand.Parameters.AddWithValue("@FechaFin", contratos.FechaFin);
            _sqlcommand.Parameters.AddWithValue("@MontoMensual", contratos.MontoMensual);
            _sqlcommand.Parameters.AddWithValue("@PropiedadID", contratos.PropiedadId);
            _sqlcommand.Parameters.AddWithValue("@InquilinoID", contratos.InquilinoId);

            _sqlcommand.ExecuteNonQuery();
            _sqlcommand.Parameters.Clear();
            _connection.CloseConnection();
        }
        public void UpdateContrato(Contratos contratos)
        {
            _sqlcommand.Connection = _connection.OpenConnection();
            _sqlcommand.CommandText = "UPDATE Contratos "
                + "SET FechaInicio = @FechaInicio, MontoMensual = @MontoMensual, PropiedadId = @PropiedadID, InquilinoId = @InquilinoID"
                + " WHERE ContratoID = @Id";
            _sqlcommand.CommandType = CommandType.Text;

            _sqlcommand.Parameters.AddWithValue("@FechaInicio", contratos.FechaInicio);
            _sqlcommand.Parameters.AddWithValue("@FechaFin", contratos.FechaFin);
            _sqlcommand.Parameters.AddWithValue("@MontoMensual", contratos.MontoMensual);
            _sqlcommand.Parameters.AddWithValue("@PropiedadID", contratos.PropiedadId);
            _sqlcommand.Parameters.AddWithValue("@InquilinoID", contratos.InquilinoId);
            _sqlcommand.Parameters.AddWithValue("@Id", contratos.Id);

            _sqlcommand.ExecuteNonQuery();
            _sqlcommand.Parameters.Clear();
            _connection.CloseConnection();

        }
        public void DeleteContrato(Contratos contratos)
        {
            _sqlcommand.Connection = _connection.OpenConnection();
            _sqlcommand.CommandText = "DELETE FROM Contratos WHERE ContratoID = @Id";
            _sqlcommand.CommandType = CommandType.Text;

            _sqlcommand.Parameters.AddWithValue("@Id", contratos.Id);

            _sqlcommand.ExecuteNonQuery();
            _sqlcommand.Parameters.Clear();
            _connection.CloseConnection();

        }

    }
}
