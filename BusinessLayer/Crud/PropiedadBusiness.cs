using CommonLayer;
using DataLayer.Data;
using System;
using System.Data;
using System.Data.SqlClient;

namespace BusinessLayer.Crud
{
    public class PropiedadBusiness
    {
        PropiedadData propiedadData = new PropiedadData();

        public DataTable GetPropiedad()
        {
            DataTable PropiedadTable = new DataTable();
            PropiedadTable = propiedadData.GetAllPropiedad();
            return PropiedadTable;
        }

        public DataTable SearchPropiedad(string search)
        {
            DataTable PropiedadTable = new DataTable();
            PropiedadTable = propiedadData.SearchPropiedad(search);
            return PropiedadTable;
        }

        public void AddPropiedad(Propiedad propiedad)
        {
            propiedadData.AddPropiedad(propiedad);
        }

        public void UpdatePropiedad(Propiedad propiedad)
        {
            propiedadData.UpdatePropiedad(propiedad);
        }

        public void DeletePropiedad(Propiedad propiedad)
        {
            propiedadData.DeletePropiedad(propiedad);
        }
    }
}
