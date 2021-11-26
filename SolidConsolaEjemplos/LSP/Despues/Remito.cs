using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidConsolaEjemplos.LSP.Despues
{
    public class Remito
    {
        public int CantBultos { get; set; }
        public int Numero { get; set; }
        public DateTime Fecha { get; set; }

        public Remito(DateTime fecha, int numero, int bultos)
        {
            this.CantBultos = bultos;
            this.Numero = numero;
            this.Fecha = fecha;
        }

        public string Imprimir()
        {
            return $"Imprimiendo {Descripcion()}";
        }

        public string Descripcion()
        {
            return $"Remito nro {Numero} de fecha {Fecha.ToShortDateString()} con {CantBultos} Bultos.";
        }

    }
}
