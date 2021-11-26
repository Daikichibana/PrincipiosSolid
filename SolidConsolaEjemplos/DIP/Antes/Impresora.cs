using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidConsolaEjemplos.DIP.Antes
{
    public class Impresora
    {
        public void Imprimir(Factura factura) 
        {
            Console.WriteLine($"Imprimiendo factura. {factura.Numero},{factura.Importe},{factura.Fecha.ToShortDateString()}.");
        }        
        
        public void Imprimir(NotaCredito notaCredito) 
        {
            Console.WriteLine($"Imprimiendo nota credito. {notaCredito.Numero}, {notaCredito.Importe}, {notaCredito.Fecha.ToShortDateString()}.");

        }

        public void Imprimir(FacturaLuz facturaLuz)
        {
            Console.WriteLine($"Imprimiendo factura luz. {facturaLuz.CodigoPago},{facturaLuz.Importe}.");
        }

        public void Imprimir(Municipal municipal)
        {
            Console.WriteLine($"Imprimiendo factura municipal. {municipal.Partida},{municipal.Importe}.");
        }

        public void Imprimir(Remito remito)
        {
            Console.WriteLine($"Imprimiendo Remito. {remito.Numero},{remito.CantBulto},{remito.Fecha.ToShortTimeString()}");
        }

        public void Imprimir(ReciboSueldo reciboSueldo)
        {
            Console.WriteLine($"Imprimiendo recibo sueldo. {reciboSueldo.Legajo},{reciboSueldo.Total}.");
        }
    }
}
