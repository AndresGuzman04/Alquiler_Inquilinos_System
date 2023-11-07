using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.Entities
{
    public class Mantenimiento
    {

        public int id { get; set; }
        public DateTime fechaMantenimiento { get; set; }
        public string descripcion { get; set; }
        public string costo { get; set; }

        public int propiedadId { get; set; }

    }
}
