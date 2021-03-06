using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidConsolaEjemplos.DIP.Despues
{
    public class Remito : IImprimible
    {
        public int Numero { get; set; }
        public DateTime Fecha { get; set; }
        public int CantBulto { get; set; }

        public Remito(int numero, DateTime fecha, int cantBulto)
        {
            this.Numero = numero;
            this.Fecha = fecha;
            this.CantBulto = cantBulto;
        }

        public void Imprimir()
        {
            Console.WriteLine($"Imprimiendo Remito. {Numero},{CantBulto},{Fecha.ToShortTimeString()}");
        }
    }
}
