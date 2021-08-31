using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practicalll.Validations
{
    public class ValidateResult
    {
        public ValidateResult()
        {
            IsValid = false;
            ErrorMessage = new List<string>();
        }
        public bool IsValid { get; set; }
        public List<string> ErrorMessage { get; set; }
    }
}
