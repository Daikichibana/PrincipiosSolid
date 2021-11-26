using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidConsolaEjemplos.LSP.Antes
{
    public class Impresora
    {
        public void ImprimirRemito(Remito remito)
        {
            Console.WriteLine(remito.Imprimir());
        }

        public void ImprimirFactura(Factura factura)
        {
            Console.WriteLine(factura.Imprimir());
        }

        public void ImprimirNotaCredito(NotaCredito notaCredito)
        {
            Console.WriteLine(notaCredito.Imprimir());
        }
    }
}
