using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolidSRP.Models
{
    public class CustomerSearch
    {
        public static List<Customer> customers = Datos.customers;

        public static List<Customer> SearchByCountry(string country)
        { 
            var response = customers.FindAll(x => x.Country.Equals(country));
            
            return response;
        }

        public static List<Customer> SearchByCompanyName(string company)
        {
            var response = customers.FindAll(x => x.CompanyName.Equals(company));

            return response;
        }

        public static List<Customer> SearchByContactName(string contact)
        {
            var response = customers.FindAll(x => x.ContactName.Equals(contact));

            return response;
        }


    }
}
