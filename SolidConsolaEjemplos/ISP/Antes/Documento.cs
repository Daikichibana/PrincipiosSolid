using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidConsolaEjemplos.ISP.Antes
{
    public abstract class Documento
    {
        public Documento(DateTime fecha, int numero)
        {
            this.Fecha = fecha;
            this.Numero = numero;
        }

        public DateTime Fecha { get; set; }
        public int Numero { get; set; }

        public abstract void Imprimir();
        public abstract void EnviarPorEmail();
    }
}
