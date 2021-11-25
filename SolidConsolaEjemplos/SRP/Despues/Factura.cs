using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidConsolaEjemplos.SRP.Despues
{
    public class Factura
    {
        public int Numero { get; set; }
        public DateTime Fecha { get; set; }
        public Cliente Cliente { get; set; }
        public List<Item> Items { get; set; }
        public Factura(
            int Numero,
            DateTime Fecha,
            Cliente cliente,
            List<Item> Items)
        {
            this.Numero = Numero;
            this.Fecha = Fecha;
            this.Cliente = cliente;
            this.Items = Items;
        }

        public double GetTotal()
        {
            double total = 0;
            foreach (var item in Items)
            {
                total += item.SubTotal();
            }

            return total;
        }

    }
}
