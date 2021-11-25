using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidConsolaEjemplos.SRP.Despues
{
    public class Cliente
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        public Cliente(string nombre, string apellido)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
        }
    }
}
