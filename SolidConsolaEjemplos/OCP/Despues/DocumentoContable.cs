using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidConsolaEjemplos.OCP.Despues
{
    public abstract class DocumentoContable
    {
        public DocumentoContable(DateTime fecha, double importe, int numero)
        {
            this.Fecha = fecha;
            this.Importe = importe;
            this.Numero = numero;
        }

        public DateTime Fecha { get; set; }
        public double Importe { get; set; }
        public int Numero { get; set; }

        public abstract string Descripcion();

    }
}
