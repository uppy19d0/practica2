using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Practicalll.Interfaces;
using Practicalll.Models;
using Practicalll.Services;
using Practicalll.Validations;

namespace Practicalll.Pages
{
    public class PrestamoModel : PageModel
    {
        private readonly IPrestamo _prestamoService;
        public PrestamoResult Prestamo { get; set; } = new PrestamoResult();
        public PrestamoModel(IPrestamo prestamoService)
        {
            _prestamoService = prestamoService;
        }
        public void OnGet()
        {
        }

        public void OnPost(Prestamo prestamo)
        {
            var prestamoValidator = new PrestamoValidator(prestamo);
            var result = prestamoValidator.Validate();
            if (result.IsValid)
            {
                _prestamoService.CalcularPrestamo(prestamo);
                Prestamo = _prestamoService.PrestamoResult;
            }
            else
            {
                Prestamo.ValidateResult = result;
            }
        }
    }
}
