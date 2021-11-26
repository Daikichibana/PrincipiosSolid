using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidConsolaEjemplos.DIP.Despues
{
    public abstract class Impuesto : IImprimible
    {
        public double Importe { get; set; }
        public Impuesto(double importe)
        {
            this.Importe = importe;
        }

        public abstract void Imprimir();
    }
}
