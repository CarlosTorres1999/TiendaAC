using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StockManagerAC.Models
{
    public class Producto
    {
       public int Id { get; set; }
       public string Nombre { get; set; }
       public string Descripcion { get; set; }
       public double Volumen { get; set; }
       public string VolumenEn { get; set; }
       public double PrecioUnitario { get; set; }
       public int Cantidad { get; set; }
    }
}
