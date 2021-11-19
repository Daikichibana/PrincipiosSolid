using Solid_O.Antes;
using Solid_O.Despues;
using System;
using System.Collections.Generic;

namespace Solid_O
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<IDrink> lstDrink = new List<IDrink>() {
                new Water { 
                    name = "agua",
                    price = 100m,
                    invoice = 0.3m
                },
                new Alcohol {
                    name = "cerveza",
                    price = 100m,
                    invoice = 0.3m,
                    promo = 0.4m
                }
            };

            decimal total = GetTotalSolid(lstDrink);
            Console.WriteLine("El precio total es: " + total);
        }

        // Codigo antes de implementar el principio:
        public static decimal GetTotal(IEnumerable<Drink> lstDrink)
        {
            decimal total = 0;
            foreach (var drink in lstDrink)
            {
                if (drink.type.Equals("Agua"))
                    total += drink.price;
                else if (drink.type.Equals("Azucar"))
                    total += drink.price * 0.22m;
                else if (drink.type.Equals("Alcohol"))
                    total += drink.price * 0.33m;
            }

            return total;
        }

        //Codigo luego de implementar el principio:
        public static decimal GetTotalSolid(IEnumerable<IDrink> lstDrink)
        {
            decimal total = 0;

            foreach (var drink in lstDrink)
            {
                total += drink.getPrice();
            }

            return total;
        }

    }
}
