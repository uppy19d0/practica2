using Practicalll.Models;
using Practicalll.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practicalll.Interfaces
{
    public interface IPrestamo
    {
        PrestamoResult PrestamoResult { get; set; }
        void CalcularPrestamo(Prestamo prestamo);
    }
}
