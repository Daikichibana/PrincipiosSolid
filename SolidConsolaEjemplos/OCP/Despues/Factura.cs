using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidConsolaEjemplos.OCP.Despues
{
    public class Factura : DocumentoContable
    {
        public Factura(DateTime fecha, int importe, int numero) : base(fecha, importe, numero) { }
        public override string Descripcion()
        {
            return $"FC-{Numero}";
        }
    }
}
