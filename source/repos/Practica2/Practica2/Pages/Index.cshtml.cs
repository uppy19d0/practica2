using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Practica2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practica2.Pages
{
    public class IndexModel : PageModel
    {

        [BindProperty]
        public Nomina nomina { get; set; }
        private readonly ILogger<IndexModel> _logger;
        public List<Nomina> _nominaList;
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            Data();
        }

        public void OnGet()
        {

        }

        public void Data()
        {
            _nominaList = new List<Nomina>()
            {

                new Nomina(){Nombre="Luis",Apellido="Tavarez",Cargo="Software Developer",SalarioMensual=60000,DescuentoAfp=DescuentoAFP(60000),DescuentoArs=DescuentoArs(60000),DescuentoIsr=DescuentoIsr(60000),TotalDescuento=TotalDescuento(60000),SalarioNeto=SalarioNeto(60000)},
                new Nomina(){Nombre="Juan",Apellido="Martinez",Cargo="Recurso Humano",SalarioMensual=58000,DescuentoAfp=DescuentoAFP(58000),DescuentoArs=DescuentoArs(58000),DescuentoIsr=DescuentoIsr(58000),TotalDescuento=TotalDescuento(58000),SalarioNeto=SalarioNeto(58000)},
                new Nomina(){Nombre="Maria",Apellido="Rodriguez",Cargo="Analista de Calidad",SalarioMensual=70000,DescuentoAfp=DescuentoAFP(70000),DescuentoArs=DescuentoArs(70000),DescuentoIsr=DescuentoIsr(70000),TotalDescuento=TotalDescuento(70000),SalarioNeto=SalarioNeto(70000)},
                new Nomina(){Nombre="Pedro",Apellido="Fermin",Cargo="GERENTE TIC",SalarioMensual=120000,DescuentoAfp=DescuentoAFP(120000),DescuentoArs=DescuentoArs(120000),DescuentoIsr=DescuentoIsr(120000),TotalDescuento=TotalDescuento(120000),SalarioNeto=SalarioNeto(120000)},
                new Nomina(){Nombre="Kellyn",Apellido="Solsa",Cargo="Developer SR",SalarioMensual=90000,DescuentoAfp=DescuentoAFP(90000),DescuentoArs=DescuentoArs(90000),DescuentoIsr=DescuentoIsr(90000),TotalDescuento=TotalDescuento(90000),SalarioNeto=SalarioNeto(90000)}
            };
        }

        public double DescuentoAFP(double salario)
        {
            var total = salario * 2.87 / 100;
            return total;
        }
        public double DescuentoArs(double salario)
        {
            var total = salario * 3.04 / 100;
            return total;
        }
        public double DescuentoIsr(double salario)
        {
            double total = 0;
            total = (salario - (DescuentoArs(salario) + DescuentoAFP(salario))) * 12;
            double limit = 624_329.01;
            if (total > limit)
            {
                total = Math.Round((((total - limit) * 0.20) + 31_216.00) / 12, 2);
            }

            return total;
        }
        public double TotalDescuento(double salario)
        {
            var total = DescuentoAFP(salario) + DescuentoArs(salario) + DescuentoIsr(salario);
            return total;
        }
        public double SalarioNeto(double salario)
        {
            var total = salario - DescuentoAFP(salario) - DescuentoArs(salario) - DescuentoIsr(salario);
            return total;
        }
    }

}
