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
    public class ContratosBusiness
    {
        ContratoData contratoData = new ContratoData();

        public DataTable GetContratos()
        {
            DataTable contratosTable = new DataTable();

            contratosTable = contratoData.GetAllContratos();

            return contratosTable;
        }

        public void AddContrato(Contratos contratos)
        {
            contratoData.AddContrato(contratos);

        }

        public void UpdateContrato(Contratos contratos)
        {
            contratoData.UpdateContrato(contratos);

        }

        public void DeleteContrato(Contratos contratos)
        {
            contratoData.DeleteContrato(contratos);

        }
    }
}
