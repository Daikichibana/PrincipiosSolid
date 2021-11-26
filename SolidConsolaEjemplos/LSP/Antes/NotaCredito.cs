using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidConsolaEjemplos.LSP.Antes
{
    public class NotaCredito : Documento
    {
        public NotaCredito(DateTime fecha, int numero) : base(fecha, numero)
        {
            _sigla = "NC";
        }
    }
}
