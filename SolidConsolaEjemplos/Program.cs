using System;
using System.Collections.Generic;

namespace SolidConsolaEjemplos
{
    class Program
    {
        static void Main(string[] args)
        {
            SRPAntes();
            SRPDespues();
        }


        public static void SRPAntes() {
            List<SRP.Antes.Item> items = new List<SRP.Antes.Item>();
            items.Add(new SRP.Antes.Item(new SRP.Antes.Producto(100),2));
            items.Add(new SRP.Antes.Item(new SRP.Antes.Producto(200),4));
            items.Add(new SRP.Antes.Item(new SRP.Antes.Producto(300),6));

            SRP.Antes.Factura factura = new SRP.Antes.Factura(1, DateTime.Now, "Chibana", "Daiki", items);

            Console.WriteLine(factura.GetTotal());
        }

        public static void SRPDespues() {
            List<SRP.Despues.Item> items = new List<SRP.Despues.Item>();
            items.Add(new SRP.Despues.Item(new SRP.Despues.Producto(100), 2));
            items.Add(new SRP.Despues.Item(new SRP.Despues.Producto(200), 4));
            items.Add(new SRP.Despues.Item(new SRP.Despues.Producto(300), 6));

            SRP.Despues.Cliente cliente = new SRP.Despues.Cliente("Daiki", "Chibana");

            SRP.Despues.Factura factura = new SRP.Despues.Factura(1, DateTime.Now, cliente, items);

            Console.WriteLine(factura.GetTotal());
        }
    }
}
