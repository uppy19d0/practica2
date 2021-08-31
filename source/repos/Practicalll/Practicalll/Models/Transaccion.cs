using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practicalll.Models
{
    public class Transaccion
    {
        public int NoRetiro { get; set; }
        public double MontoRetiro { get; set; }
        public List<string> billetes { get; set; }

    }
}
