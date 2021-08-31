using Practicalll.Validations;
using Practicalll.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practicalll.Validations
{
    public class PrestamoValidator
    {
        private Prestamo Prestamo { get; }
        public PrestamoValidator(Prestamo prestamo)
        {
            Prestamo = prestamo;
        }
        public ValidateResult Validate()
        {
            var result = new ValidateResult();
            if (Prestamo.Interes <= 0 && Prestamo.Monto <= 0 && Prestamo.Cuotas <= 0)
            {
                result.ErrorMessage.Add("El interes introducido es invalido.");
                result.ErrorMessage.Add("El monto introducido es invalido.");
                result.ErrorMessage.Add("La cuota introducida es invalida.");
                result.IsValid = false;
            }
            else
            {
                result.ErrorMessage.Add("");
                result.IsValid = true;
            }
            return result;
        }
    }
}
