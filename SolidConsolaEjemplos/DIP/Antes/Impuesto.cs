using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidConsolaEjemplos.DIP.Antes
{
    public abstract class Impuesto
    {
        public double Importe { get; set; }
        public Impuesto(double importe)
        {
            this.Importe = importe;
        }
    }
}
