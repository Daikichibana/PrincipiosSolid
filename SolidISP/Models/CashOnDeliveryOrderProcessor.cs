using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolidISP.Models
{
    public class CashOnDeliveryOrderProcessor : IOrderProcessor
    {
        public string ProcessOrder(Order obj)
        {
            return "The cash process was succesful!";
        }

        public bool ValidateShippingAddress(Address obj)
        {
            return true;
        }
    }
}
