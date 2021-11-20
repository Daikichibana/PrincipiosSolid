using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SolidSRP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolidSRP.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class CustomerController : Controller
    { 
        public ActionResult Index()
        {
            return View();
        }

        public List<Customer> GetData(string criteria, string searchby)
        {
            List<Customer> data = null;

            switch (searchby)
            {
                case "companyname":
                    data = CustomerSearch.SearchByCompanyName(criteria);
                    break;
                case "contactname":
                    data = CustomerSearch.SearchByContactName(criteria);
                    break;
                case "country":
                    data = CustomerSearch.SearchByCountry(criteria);
                    break;
            }

            return data;
        }

        [HttpGet]
        public List<Customer> Search(string criteria, string searchby)
        {
            List<Customer> model = GetData(criteria, searchby);

            return model;
        }

        [HttpPost]
        public FileResult Export(string criteria, string searchby)
        {
            List<Customer> data = GetData(criteria, searchby);
            string exportData = CustomerDataExporter.ExportToCSV(data);
            return File(System.Text.ASCIIEncoding.ASCII.GetBytes(exportData), "application/Excel");
        }

    }
}
