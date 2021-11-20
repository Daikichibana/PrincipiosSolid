using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolidSRP.Models
{
    public static class Datos
    {
        public static List<Customer> customers = new List<Customer>()
        {
            new Customer{
                CustomerID = "A1",
                CompanyName = "Microsoft",
                ContactName = "Bill Gates",
                Country = "United States"
            },
            new Customer{
                CustomerID = "A2",
                CompanyName = "Amazon",
                ContactName = "Jeff Bezos",
                Country = "United States"
            },
            new Customer{
                CustomerID = "A3",
                CompanyName = "Alibaba",
                ContactName = "Jack Ma",
                Country = "China"
            },
        };


    }
}
