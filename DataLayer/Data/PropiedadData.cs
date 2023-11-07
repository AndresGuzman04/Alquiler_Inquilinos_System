using CommonLayer;
using System.Data;
using System.Data.SqlClient;

namespace DataLayer.Data
{
    public class PropiedadData
    {
        Connection _connection = new Connection();
        SqlDataReader _reader;
        SqlCommand _cmd = new SqlCommand();
        DataTable PropiedadTable = new DataTable();

        public DataTable GetAllPropiedad()
        {
            _cmd.Connection = _connection.OpenConnection();
            _cmd.CommandText = "SELECT * FROM Propiedades";
            _cmd.CommandType = CommandType.Text;
            _reader = _cmd.ExecuteReader();
            PropiedadTable.Load(_reader);
            _connection.CloseConnection();
            return PropiedadTable;
        }

        public DataTable SearchPropiedad(string search)
        {
            _cmd.Connection = _connection.OpenConnection();
            _cmd.CommandText = "SELECT * FROM Propiedades WHERE Nombre LIKE '%' + @search + '%'";
            _cmd.CommandType = CommandType.Text;
            _cmd.Parameters.AddWithValue("@search", search);
            _reader = _cmd.ExecuteReader();
            PropiedadTable.Load(_reader);
            _connection.CloseConnection();
            return PropiedadTable;
        }

        public void AddPropiedad(Propiedad Propiedad)
        {
            _cmd.Connection = _connection.OpenConnection();
            _cmd.CommandText = "INSERT INTO Propiedades(Nombre, Direccion, TipoPropiedad, PrecioMensual)"
                + "VALUES(@Nombre , @Direccion, @TipoPropiedad, @PagoMensual)";
            _cmd.CommandType = CommandType.Text;
            _cmd.Parameters.AddWithValue("@Nombre", Propiedad.Nombre);
            _cmd.Parameters.AddWithValue("@Direccion", Propiedad.Direccion);
            _cmd.Parameters.AddWithValue("@TipoPropiedad", Propiedad.TipoPropiedad);
            _cmd.Parameters.AddWithValue("@PagoMensual", Propiedad.PagoMensual);
            _cmd.ExecuteNonQuery();
            _cmd.Parameters.Clear();
            _connection.CloseConnection();
        }

        public void UpdatePropiedad(Propiedad propiedad)
        {
            _cmd.Connection = _connection.OpenConnection();
            _cmd.CommandText = "UPDATE Propiedades SET Nombre=@Nombre, Direccion=@Direccion, TipoPropiedad=@TipoPropiedad, PrecioMensual=@PagoMensual " +
                "WHERE PropiedadID = @id";
            _cmd.CommandType = CommandType.Text;
            _cmd.Parameters.AddWithValue("@Nombre", propiedad.Nombre);
            _cmd.Parameters.AddWithValue("@Direccion", propiedad.Direccion);
            _cmd.Parameters.AddWithValue("@TipoPropiedad", propiedad.TipoPropiedad);
            _cmd.Parameters.AddWithValue("@PagoMensual", propiedad.PagoMensual);
            _cmd.Parameters.AddWithValue("@id", propiedad.id);
            _cmd.ExecuteNonQuery();
            _cmd.Parameters.Clear();
            _connection.CloseConnection();
        }

        public void DeletePropiedad(Propiedad propiedad)
        {
            _cmd.Connection = _connection.OpenConnection();
            _cmd.CommandText = "DELETE FROM Propiedades WHERE PropiedadID = @id";
            _cmd.CommandType = CommandType.Text;
            _cmd.Parameters.AddWithValue("@id", propiedad.id);
            _cmd.ExecuteNonQuery();
            _cmd.Parameters.Clear();
            _connection.CloseConnection();
        }
    }
}