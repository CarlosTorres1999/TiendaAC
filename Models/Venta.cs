using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockManagerAC.Models
{
    public class Venta
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string DescripcionVenta { get; set; }
        public double Volumen { get; set; }
        public string VolumenEn { get; set; }
        public string PrecioUnitario { get; set; }
        public string Cantidad { get; set; }
        public string Tipo { get; set; }
    }
}
