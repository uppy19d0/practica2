using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Practicalll.Models;

namespace Practicalll.Pages
{

    public class CajeroModel : PageModel
    {

        public List<Transaccion> Retiros = new List<Transaccion>();
        public string MensajeError = $"";
        int secuencia = 0;

        public Dictionary<int, int> Monedas = new Dictionary<int, int>() {
            {1000, 9},
            {500, 19},
            {100, 99}
            };


        public void OnPostSubmit(double MontoRetirar, string Banco)
        {
            double MontoDisponible = (Monedas[1000] * 1000) + (Monedas[500] * 500) + (Monedas[100] * 100);

            MensajeError = $"";

            if ((Banco == "ABC") && (MontoRetirar > 10000))
            {
                MensajeError = $"El banco ABC solo permite realizar retiros por un monto de hasta RD$ 10,000 via cajero, Verifique e intente nuevamente";
                MontoRetirar = 0;
            }

            if ((Banco != "ABC") && (MontoRetirar > 2000))
            {
                MensajeError = $"El banco Otros Bancos solo permite realizar retiros por un monto de hasta RD$ 2,000 via cajero, Verifique e intente nuevamente";
                MontoRetirar = 0;

            }

            if (MontoRetirar > 0)
            {
                if (MontoRetirar > MontoDisponible)
                {
                    MensajeError = $"No existe disponibilidad para realizar dicho retiro. Disponibilidad de RD$ {MontoDisponible:N3} , Verifique e intente nuevamente";

                }
                else
                {

                    List<string> RetirosMonedas = new List<string>();
                    Transaccion retiro = new Transaccion();
                    secuencia = Retiros.Count;
                    secuencia++;


                    retiro.MontoRetiro = MontoRetirar;
                    retiro.NoRetiro = secuencia;

                    foreach (KeyValuePair<int, int> mon in this.Monedas)
                    {
                        double disponibleMoneda = mon.Key * mon.Value;
                        int cantRebajar = 0;

                        if ((MontoRetirar > disponibleMoneda) && (disponibleMoneda > 0))
                        {
                            cantRebajar = mon.Value;
                        }
                        else
                        {
                            cantRebajar = (int)MontoRetirar / mon.Key;
                        }

                        if (cantRebajar > 0)
                        {
                            RetirosMonedas.Add($"{cantRebajar} billetes de {mon.Key}");
                        }

                        Monedas[mon.Key] -= cantRebajar;
                        MontoRetirar -= (cantRebajar * mon.Key);
                    }

                    if (RetirosMonedas.Count() > 0)
                    {
                        retiro.billetes = RetirosMonedas;
                        Retiros.Add(retiro);
                    }
                }

            }

        }

        public void OnGet()
        {

        }
    }

}
