using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidConsolaEjemplos.LSP.Antes
{
    public abstract class Documento
    {
        public DateTime Fecha { get; set; }
        public int Numero { get; set; }
        protected string _sigla { get; set; }

        public Documento(DateTime fecha, int numero)
        {
            this.Fecha = fecha;
            this.Numero = Numero;
        }

        public string Imprimir()
        {
            return $"Imprimiendo {Descripcion()}";
        }

        public virtual string Descripcion()
        {
            return $"{_sigla} nro {Numero} de fecha {Fecha.ToShortDateString()}";
        }

    }
}
