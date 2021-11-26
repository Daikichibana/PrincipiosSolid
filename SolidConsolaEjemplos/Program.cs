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
            Console.WriteLine("-------------");
            OCPAntes();
            OCPDespues();
            Console.WriteLine("-------------");
            LSPAntes();
            LSPDespues();
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

        public static void OCPAntes()
        {
            OCP.Antes.DocumentoContable documentoContable = new OCP.Antes.DocumentoContable(DateTime.Now, 100, 1, OCP.Antes.TipoDocumentoContable.NotaCredito);
            OCP.Antes.DocumentoContable documentoContable2 = new OCP.Antes.DocumentoContable(DateTime.Now, 200, 2, OCP.Antes.TipoDocumentoContable.Factura);

            Console.WriteLine(documentoContable.Descripcion());
            Console.WriteLine(documentoContable2.Descripcion());
        }

        public static void OCPDespues()
        {
            OCP.Despues.NotaCredito notaCredito = new OCP.Despues.NotaCredito(DateTime.Now,100,1);
            OCP.Despues.Factura facturaCredito = new OCP.Despues.Factura(DateTime.Now,200,2);

            Console.WriteLine(notaCredito.Descripcion());
            Console.WriteLine(facturaCredito.Descripcion());
        }

        public static void LSPAntes()
        {
            LSP.Antes.Impresora impresora = new LSP.Antes.Impresora();
            LSP.Antes.Remito remito = new LSP.Antes.Remito(DateTime.Now, 1, 100);
            LSP.Antes.Factura factura = new LSP.Antes.Factura(DateTime.Now, 1);
            LSP.Antes.NotaCredito notaCredito = new LSP.Antes.NotaCredito(DateTime.Now, 1);

            impresora.ImprimirRemito(remito);
            impresora.ImprimirFactura(factura);
            impresora.ImprimirNotaCredito(notaCredito);
        }

        public static void LSPDespues()
        {
            LSP.Despues.Impresora impresora = new LSP.Despues.Impresora();
            LSP.Despues.Remito remito = new LSP.Despues.Remito(DateTime.Now, 1, 100);
            LSP.Despues.Factura factura = new LSP.Despues.Factura(DateTime.Now, 1);
            LSP.Despues.NotaCredito notaCredito = new LSP.Despues.NotaCredito(DateTime.Now, 1);

            impresora.ImprimirRemito(remito);
            impresora.Imprimir(factura);
            impresora.Imprimir(notaCredito);

        }


    }

}
