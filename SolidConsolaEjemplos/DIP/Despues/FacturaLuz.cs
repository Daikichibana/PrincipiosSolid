using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidConsolaEjemplos.DIP.Despues
{
    public class FacturaLuz : Impuesto
    {
        public string CodigoPago { get; set; }
        public FacturaLuz(double importe, string codigoPago) : base(importe)
        {
            this.CodigoPago = codigoPago;
        }

        public override void Imprimir()
        {
            Console.WriteLine($"Imprimiendo factura luz. {CodigoPago},{Importe}.");
        }
    }
}
