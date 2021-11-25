using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidConsolaEjemplos.OCP.Despues
{
    public class NotaCredito : DocumentoContable
    {
        public NotaCredito(DateTime fecha, int importe, int numero) : base(fecha, importe, numero) { }
        public override string Descripcion()
        {
            return $"NC-{Numero}";
        }
    }
}
