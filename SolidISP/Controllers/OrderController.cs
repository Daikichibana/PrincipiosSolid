using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SolidISP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolidISP.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        [HttpGet]
        public string ProcessOrder(string paymentmode)
        {
            Customer customer = new Customer();
            Address address = new Address();
            CardInfo cardInfo = new CardInfo();

            Order order = new Order();
            order.OrderID = new Random().Next(1000,9000);
            order.Customer = customer;
            order.ShippingAddress = address;
            order.CardInfo = cardInfo;

            string response = string.Empty;

            if (paymentmode.Equals("card"))
            {
                OnlineOrderProcessor oop = new OnlineOrderProcessor();
                cardInfo = new CardInfo();
                cardInfo.CardNo = "555444";
                cardInfo.ExpiryMonth = 12;
                cardInfo.ExpiryYear = 2015;
                order.CardInfo = cardInfo;
                oop.ValidateCardInfo(cardInfo);
                oop.ValidateShippingAddress(address);

                response = oop.ProcessOrder(order);
            }
            else 
            {
                CashOnDeliveryOrderProcessor codop = new CashOnDeliveryOrderProcessor();
                codop.ValidateShippingAddress(address);

                response = codop.ProcessOrder(order);
            }

            return response;
        }

    }
}
