using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidConsolaEjemplos.DIP.Antes
{
    public class ReciboSueldo
    {
        public ReciboSueldo(int total, string legajo)
        {
            this.Total = total;
            this.Legajo = legajo;
        }

        public int Total { get; set; }
        public string Legajo { get; set; }
    }
}
