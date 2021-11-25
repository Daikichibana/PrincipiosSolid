using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidConsolaEjemplos.SRP.Despues
{
    public class Producto
    {
        public int Precio { get; set; }

        public Producto(int precio)
        {
            this.Precio = precio;
        }
    }
}
