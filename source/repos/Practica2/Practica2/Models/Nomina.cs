using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practica2.Models
{
    public class Nomina
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Cargo { get; set; }
        public double SalarioMensual { get; set; }
        public double DescuentoAfp { get; set; }
        public double DescuentoArs { get; set; }
        public double DescuentoIsr { get; set; }
        public double TotalDescuento { get; set; }
        public double SalarioNeto{get; set;}


    }
}
