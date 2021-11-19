using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_O.Despues
{
    interface IDrink
    {
        public string name { get; set; }
        public decimal price { get; set; }
        public decimal invoice { get; set; }
        public decimal getPrice();
    }
}
