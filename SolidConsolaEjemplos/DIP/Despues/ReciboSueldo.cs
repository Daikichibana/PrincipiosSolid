using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidConsolaEjemplos.DIP.Despues
{
    public class ReciboSueldo : IImprimible
    {
        public ReciboSueldo(int total, string legajo)
        {
            this.Total = total;
            this.Legajo = legajo;
        }

        public int Total { get; set; }
        public string Legajo { get; set; }

        public void Imprimir()
        {
            Console.WriteLine($"Imprimiendo recibo sueldo. {Legajo},{Total}.");
        }
    }
}
