using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolidISP.Models
{
    interface IOnlineOrderProcessor
    {
        bool ValidateCardInfo(CardInfo obj);
    }
}
