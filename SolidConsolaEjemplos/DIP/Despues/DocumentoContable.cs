using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidConsolaEjemplos.DIP.Despues
{
    public abstract class DocumentoContable : IImprimible
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

        public abstract void Imprimir();
    }
}
