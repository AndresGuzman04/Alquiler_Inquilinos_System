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
    public class InquilinoBusiness
    {
        InquilinoData inquilinoData = new InquilinoData();

        public DataTable GetInquilinos()
        {
            DataTable inquilinosTable = new DataTable();

            inquilinosTable = inquilinoData.GetAllInquilinos();

            return inquilinosTable;
        }

        public void AddInquilino(Inquilino inquilino)
        {

            inquilinoData.AddInquilino(inquilino);

        }

        public void UpdateInquilino(Inquilino inquilino)
        {
            inquilinoData.UpdateInquilino(inquilino);

        }

        public void DeleteInquilino(Inquilino inquilino)
        {
            inquilinoData.DeleteInquilino(inquilino);

        }
    }
}
