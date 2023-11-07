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
    public class PagoBusiness
    {

        PagoData pagoData = new PagoData();

        public DataTable GetPagos()
        {

            DataTable pagosTable = new DataTable();

            pagosTable = pagoData.GetAllPagos();

            return pagosTable;
        }

        public void AddPago(Pago pago)
        {

            pagoData.AddPago(pago);

        }

        public void UpdatePago(Pago pago)
        {

            pagoData.UpdatePago(pago);

        }
        public void DeletePago(Pago pago)
        {

            pagoData.DeletePago(pago);

        }

    }
}
