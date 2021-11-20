using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolidISP.Models
{
    public interface IOrderProcessor
    {
        bool ValidateShippingAddress(Address obj);
        string ProcessOrder(Order obj);
    }
}
