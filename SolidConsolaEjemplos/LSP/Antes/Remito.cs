using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidConsolaEjemplos.LSP.Antes
{
    public class Remito : Documento
    {
        public int CantBultos { get; set; }
        public Remito(DateTime fecha, int numero, int bultos) : base(fecha, numero)
        {
            CantBultos = bultos;
        }

        public override string Descripcion()
        {
            return $"Remito nro {Numero} de fecha {Fecha.ToShortDateString()} con {CantBultos} Bultos.";
        }
    }
}
