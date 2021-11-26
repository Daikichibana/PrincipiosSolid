using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidConsolaEjemplos.DIP.Despues
{
    public class Impresora
    {
        public void Imprimir(IImprimible imprimible) 
        {
            imprimible.Imprimir();
        }        
        
    }
}
