using Microsoft.AspNetCore.Mvc;
using SolidOCP.Models;

namespace SolidOCP.Controllers
{

    [ApiController]
    [Route("[controller]/[action]")]
    public class TaxController : ControllerBase
    {
        [HttpPost]
        public decimal CalculateTax(IncomeDetails obj)
        {
            ICountryCalculator t = null;
            switch (obj.Country)
            {
                case "USA":
                    t = new TaxCalculatorForUS();
                    break;
                case "UK":
                    t = new TaxCalculatorForUk();
                    break;
                case "IN":
                    t = new TaxCalculatorForIN();
                    break;
            }

            t.TotalIncome = obj.TotalIncome;
            t.TotalDeduction = obj.TotalDeduction;
            TaxCalculator cal = new TaxCalculator();
            return cal.Calculate(t);
        }
    }
}
