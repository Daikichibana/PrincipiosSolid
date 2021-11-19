using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid_O.Despues
{
    public class Alcohol : IDrink
    {
        public string name { get; set; }
        public decimal price { get; set; }
        public decimal invoice { get; set; }
        public decimal promo { get; set; }

        public decimal getPrice()
        {
            return (price * invoice) - promo;
        }
    }
}
