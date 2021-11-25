using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidConsolaEjemplos.SRP.Antes
{
    public class Factura
    {
        public int Numero { get; set; }
        public DateTime Fecha { get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public List<Item> Items { get; set; }
        public Factura(int Numero, DateTime Fecha,
            string Apellido, string Nombre, List<Item> Items)
        {
            this.Numero = Numero;
            this.Fecha = Fecha;
            this.Apellido = Apellido;
            this.Nombre = Nombre;
            this.Items = Items;
        }

        public double GetTotal()
        {
            double total = 0;
            foreach (var item in Items)
            {
                total += item.Cantidad * item.Producto.Precio;
            }

            return total;
        }

    }
}
