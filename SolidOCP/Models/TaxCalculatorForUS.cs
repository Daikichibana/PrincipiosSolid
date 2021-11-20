using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolidOCP.Models
{
    public class TaxCalculatorForUS : ICountryCalculator
    {
        public decimal TotalIncome { get; set; }
        public decimal TotalDeduction { get; set; }

        public decimal CalculateTaxAmount()
        {
            decimal taxableIncome = TotalIncome - TotalDeduction;
            return taxableIncome * 30 / 100;
        }
    }
}
