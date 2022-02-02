using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockManagerAC.Models
{
    public class Moroso
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Detalle { get; set; }
        public double Debe { get; set; }
    }
}
