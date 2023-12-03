using CommonLayer.Entities;
using DataLayer.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Crud
{
    public class MantenimientoBusiness
    {

        MantenimientoData mantenimientoData = new MantenimientoData();

        public DataTable GetMantenimientos()
        {

            DataTable mantenimientosTable = new DataTable();

            mantenimientosTable = mantenimientoData.GetAllMantenimientos();

            return mantenimientosTable;
        }


        public void AddMantenimiento(Mantenimiento mantenimiento)
        {

            mantenimientoData.AddMantenimiento(mantenimiento);

        }

        public int GetPropiedadID(Mantenimiento mantenimiento) {
            return mantenimientoData.GetPropiedadID(mantenimiento);
        }

        public void Updatemantenimiento(Mantenimiento mantenimiento)
        {

            mantenimientoData.UpdateMantenimiento(mantenimiento);

        }
        public void DeleteMantenimiento(Mantenimiento mantenimiento)
        {

            mantenimientoData.DeleteMantenimiento(mantenimiento);

        }

    }
}
