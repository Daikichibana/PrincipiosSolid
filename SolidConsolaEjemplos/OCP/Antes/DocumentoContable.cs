using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidConsolaEjemplos.OCP.Antes
{
    public class DocumentoContable
    {
        public DocumentoContable(DateTime fecha, double importe, int numero, TipoDocumentoContable tipo)
        {
            this.Fecha = fecha;
            this.Importe = importe;
            this.Numero = numero;
            this.Tipo = tipo;
        }
        public DateTime Fecha { get; set; }
        public double Importe { get; set; }
        public int Numero { get; set; }
        public TipoDocumentoContable Tipo { get; set; }

        public string Descripcion()
        {
            switch (Tipo)
            {
                case TipoDocumentoContable.Factura:
                    return $"FC-{Numero}";
                case TipoDocumentoContable.NotaCredito:
                    return $"NC-{Numero}";
                default:
                    return $"N/D";
            }
        }

    }
}
