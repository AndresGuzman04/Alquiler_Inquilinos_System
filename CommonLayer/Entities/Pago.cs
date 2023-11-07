using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.Entities
{
    public class Pago
    {

        public int id { get; set; }
        public DateTime fechaPago { get; set; }
        public string monto { get; set; }
        public int contratoID { get; set; }


    }
}
