using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jardines2023.Entidades.Entidades
{
    public class Venta
    {
        public int ventaId { get; set; }
        public int uduarioId { get; set; }
        public int clienteid { get; set; }
        public DateTime Fecha { get; set; }
        public byte[] Rowversion { get; set; }

    }
}
