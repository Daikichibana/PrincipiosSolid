using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidConsolaEjemplos.ISP.Despues
{
    public abstract class Documento : IImprimible
    {
        public Documento(DateTime fecha, int numero)
        {
            this.Fecha = fecha;
            this.Numero = numero;
        }

        public DateTime Fecha { get; set; }
        public int Numero { get; set; }

        public abstract void Imprimir();
    }
}
