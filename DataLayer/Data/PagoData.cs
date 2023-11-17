using CommonLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Data
{
    public class PagoData
    {

        Connection _connection = new Connection();
        SqlDataReader _readerRows;
        SqlCommand _sqlCommand = new SqlCommand();
        DataTable pagosTable = new DataTable();

        public DataTable GetAllPagos()
        {
            _sqlCommand.Connection = _connection.OpenConnection();
            _sqlCommand.CommandText = "SELECT Pagos.ContratoID AS ID, Pagos.FechaPago AS Fecha," +
                " Pagos.Monto, Contratos.ContratoID AS Contrato FROM Pagos INNER JOIN Contratos" +
                " ON Contratos.ContratoID = Pagos.ContratoID;";
            _sqlCommand.CommandType = CommandType.Text;

            _readerRows = _sqlCommand.ExecuteReader();
            pagosTable.Load(_readerRows);

            _connection.CloseConnection();

            return pagosTable;
        }

        public void AddPago(Pago pago)
        {

            _sqlCommand.Connection = _connection.OpenConnection();
            _sqlCommand.CommandText = "INSERT INTO Pagos(FechaPago, Monto, ContratoID)"
                + " VALUES(@FechaPago, @Monto, @ContratoID)";

            _sqlCommand.Parameters.AddWithValue("@FechaPago", pago.fechaPago);
            _sqlCommand.Parameters.AddWithValue("@Monto", pago.monto);
            _sqlCommand.Parameters.AddWithValue("@ContratoID", pago.contratoID);

            _sqlCommand.ExecuteNonQuery();
            _sqlCommand.Parameters.Clear();

            _connection.CloseConnection();

        }

        public void UpdatePago(Pago pago)
        {

            _sqlCommand.Connection = _connection.OpenConnection();
            _sqlCommand.CommandText = "UPDATE Pagos"
                + " SET FechaPago = @FechaPago, Monto = @Monto, ContratoID = @ContratoID"
                + " WHERE PagoId = @Id";

            _sqlCommand.Parameters.AddWithValue("@Id", pago.id);
            _sqlCommand.Parameters.AddWithValue("@FechaPago", pago.fechaPago);
            _sqlCommand.Parameters.AddWithValue("@Monto", pago.monto);
            _sqlCommand.Parameters.AddWithValue("@ContratoID", pago.contratoID);

            _sqlCommand.ExecuteNonQuery();
            _sqlCommand.Parameters.Clear();

            _connection.CloseConnection();

        }

        public void DeletePago(Pago pago)
        {

            _sqlCommand.Connection = _connection.OpenConnection();
            _sqlCommand.CommandText = "DELETE FROM Pagos WHERE PagoId = @Id";

            _sqlCommand.Parameters.AddWithValue("@Id", pago.id);

            _sqlCommand.ExecuteNonQuery();
            _sqlCommand.Parameters.Clear();

            _connection.CloseConnection();

        }

    }
}
