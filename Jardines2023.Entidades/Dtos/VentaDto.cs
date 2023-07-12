using Jardines2023.Entidades.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jardines2023.Entidades.Dtos
{
    public class VentaDto
    {
        public int VentaId { get; set; }
        public DateTime Fecha { get; set; }
        public int MyProperty { get; set; }
        public string cliente { get; set; }
        public decimal total { get; set; }
    }
}
