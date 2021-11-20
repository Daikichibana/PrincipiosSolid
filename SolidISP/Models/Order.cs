using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolidISP.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public Customer Customer { get; set; }
        public Address ShippingAddress { get; set; }
        public CardInfo CardInfo { get; set; }
    }
}
