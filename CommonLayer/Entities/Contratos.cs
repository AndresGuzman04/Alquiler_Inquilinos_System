using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLayer.Entities
{
    public class Contratos
    {
        public int Id { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string MontoMensual { get; set; }
        public int PropiedadId { get; set; }
        public int InquilinoId { get; set; }
    }
}
