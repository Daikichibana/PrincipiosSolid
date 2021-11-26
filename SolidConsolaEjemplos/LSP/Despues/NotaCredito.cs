using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidConsolaEjemplos.LSP.Despues
{
    public class NotaCredito : Documento
    {
        public NotaCredito(DateTime fecha, int numero) : base(fecha, numero)
        {
            _sigla = "NC";
        }
    }
}
