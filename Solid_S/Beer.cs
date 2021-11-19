using System;

namespace Solid_S
{
    public class Beer
    {
        public string name { get; set; }
        public string brand { get; set; }
        public Beer(string name, string brand)
        {
            this.name = name;
            this.brand = brand;
        }

        /* Codigo antes de aplicar el princio.

        public void Send()
        {
            Console.WriteLine($"Enviamos: {name} y {brand}.");
        }

        public void Save()
        {
            Console.WriteLine($"Guardamos: {name} y {brand}.");
        }

        */
    }
}
