using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidConsolaEjemplos.LSP.Despues
{
    public class Impresora
    {
        public void ImprimirRemito(Remito remito)
        {
            Console.WriteLine(remito.Imprimir());
        }

        public void Imprimir(Documento documento)
        {
            Console.WriteLine(documento.Imprimir());
        }
    }
}
