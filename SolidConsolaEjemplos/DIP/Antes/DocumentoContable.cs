using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidConsolaEjemplos.DIP.Antes
{
    public abstract class DocumentoContable
    {
        protected string _sigla { get; set; }
        public int Numero { get; set; }
        public DateTime Fecha { get; set; }
        public double Importe { get; set; }

        public DocumentoContable(int numero, DateTime fecha, double importe)
        {
            this.Numero = numero;
            this.Fecha = fecha;
            this.Importe = importe;
        }

        public abstract double Total();
    }
}
