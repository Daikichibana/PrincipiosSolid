using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidConsolaEjemplos.ISP.Despues
{
    public class Factura : Documento
    {
        public Factura(DateTime fecha, int numero) : base(fecha, numero)
        {
        }

        public override void Imprimir()
        {
            Console.WriteLine($"Imprimiendo Factura Fisica. {Numero} en fecha {Fecha}");
        }
    }
}
