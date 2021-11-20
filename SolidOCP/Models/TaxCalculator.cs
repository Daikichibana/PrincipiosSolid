using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolidOCP.Models
{
    public class TaxCalculator
    {
        public decimal Calculate(ICountryCalculator obj)
        {
            decimal taxAmount = obj.CalculateTaxAmount();
            return taxAmount;
        }
    }
}
