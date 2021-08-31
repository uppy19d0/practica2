using Practicalll.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practicalll.Services
{
    public class PrestamoResult
    {
        public PrestamoResult()
        {
            ValidateResult = new ValidateResult();
        }
        public double DeudaTotal { get; set; }
        public double CoutaMensual { get; set; }
        public ValidateResult ValidateResult { get; set; }
    }
}
