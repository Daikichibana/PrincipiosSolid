using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidConsolaEjemplos.DIP.Despues
{
    public class Municipal : Impuesto
    {
        public string Partida { get; set; }
        public Municipal(double importe, string partida) : base(importe)
        {
            this.Partida = partida;
        }

        public override void Imprimir()
        {
            Console.WriteLine($"Imprimiendo factura municipal. {Partida},{Importe}.");
        }
    }
}
