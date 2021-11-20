using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolidISP.Models
{
    public class OnlineOrderProcessor : IOrderProcessor, IOnlineOrderProcessor
    {
        public string ProcessOrder(Order obj)
        {
            return "The online process was succesful!";
        }

        public bool ValidateCardInfo(CardInfo obj)
        {
            return true;
        }

        public bool ValidateShippingAddress(Address obj)
        {
            return true;
        }
    }
}
