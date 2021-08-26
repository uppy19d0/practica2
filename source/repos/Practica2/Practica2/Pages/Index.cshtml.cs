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

                new Nomina(){Nombre="Luis",Apellido="Tavarez",Cargo="Software Developer",SalarioMensual=60000,DescuentoAfp=DescuentoAFP(60000),DescuentoArs=DescuentoArs(60000),DescuentoIsr=DescuentoIsr(60000),TotalDescuento=TotalDescuento(DescuentoAFP(60000),DescuentoArs(60000),DescuentoIsr(60000)),SalarioNeto=SalarioNeto(60000,DescuentoAFP(60000),DescuentoArs(60000),DescuentoIsr(60000))},
                new Nomina(){Nombre="Juan",Apellido="Martinez",Cargo="Recurso Humano",SalarioMensual=50000,DescuentoAfp=DescuentoAFP(50000),DescuentoArs=DescuentoArs(50000),DescuentoIsr=DescuentoIsr(50000),TotalDescuento=TotalDescuento(DescuentoAFP(50000),DescuentoArs(50000),DescuentoIsr(50000)),SalarioNeto=SalarioNeto(50000,DescuentoAFP(50000),DescuentoArs(50000),DescuentoIsr(50000))},
                new Nomina(){Nombre="Maria",Apellido="Rodriguez",Cargo="Analista de Calidad",SalarioMensual=40000,DescuentoAfp=DescuentoAFP(40000),DescuentoArs=DescuentoArs(40000),DescuentoIsr=DescuentoIsr(40000),TotalDescuento=TotalDescuento(DescuentoAFP(40000),DescuentoArs(40000),DescuentoIsr(40000)),SalarioNeto=SalarioNeto(40000,DescuentoAFP(40000),DescuentoArs(40000),DescuentoIsr(40000))},
                new Nomina(){Nombre="Pedro",Apellido="Fermin",Cargo="GERENTE TIC",SalarioMensual=120000,DescuentoAfp=DescuentoAFP(120000),DescuentoArs=DescuentoArs(120000),DescuentoIsr=DescuentoIsr(120000),TotalDescuento=TotalDescuento(DescuentoAFP(120000),DescuentoArs(120000),DescuentoIsr(120000)),SalarioNeto=SalarioNeto(120000,DescuentoAFP(120000),DescuentoArs(120000),DescuentoIsr(120000))},
                new Nomina(){Nombre="Kellyn",Apellido="Solsa",Cargo="Developer SR",SalarioMensual=90000,DescuentoAfp=DescuentoAFP(90000),DescuentoArs=DescuentoArs(90000),DescuentoIsr=DescuentoIsr(90000),TotalDescuento=TotalDescuento(DescuentoAFP(90000),DescuentoArs(90000),DescuentoIsr(90000)),SalarioNeto=SalarioNeto(90000,DescuentoAFP(90000),DescuentoArs(90000),DescuentoIsr(90000))},
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

            if (salario * 12 >= 416220)
            {
                total = salario * 15 / 100;
            }
            if (salario * 12 >= 624329)
            {
                total = salario * 20 / 100;
            }
            if (salario * 12 >= 867123)
            {
                total = salario * 25 / 100;
            }


            return total;
        }
        public double TotalDescuento(double afp, double ars, double isr)
        {
            var total = afp + ars + isr;
            return total;
        }
        public double SalarioNeto(double salario, double afp, double ars, double isr)
        {
            var total = salario - afp - ars - isr;
            return total;
        }
    }

}
