using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidConsolaEjemplos.ISP.Despues
{
    public class FacturaElectronica : Documento, IEmailable
    {
        public string CAE { get; set; }
        public FacturaElectronica(DateTime fecha, int numero, string cae) : base(fecha, numero)
        {
            this.CAE = cae;
        }

        public void EnviarPorEmail()
        {
            Console.WriteLine($"Enviando Factura Electronica. {Numero} en fecha {Fecha}");
        }

        public override void Imprimir()
        {
            Console.WriteLine($"Imprimiendo Factura Electronica. {Numero} en fecha {Fecha}");
        }
    }
}
