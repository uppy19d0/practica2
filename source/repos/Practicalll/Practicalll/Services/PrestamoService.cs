using Practicalll.Interfaces;
using Practicalll.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practicalll.Services
{
    public class PrestamoService : IPrestamo
    {
        private bool IsBusy = false;
        public PrestamoResult PrestamoResult { get; set; } = new PrestamoResult();
        public PrestamoService()
        {
            IsBusy = true;
        }
        public void CalcularPrestamo(Prestamo prestamo)
        {
            if (!IsBusy) return;
            double porcientoInteres = Convert.ToDouble(prestamo.Monto * prestamo.Interes / 100);
            PrestamoResult.DeudaTotal = prestamo.Monto + porcientoInteres;
            PrestamoResult.CoutaMensual = Math.Floor(PrestamoResult.DeudaTotal / 12);
            PrestamoResult.ValidateResult.IsValid = true;
        }
    }
}
