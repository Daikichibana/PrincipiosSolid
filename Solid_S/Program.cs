using Serilog;
using System;
using System.IO;

namespace Solid_S
{
    class Program
    {
        static void Main(string[] args)
        {
            //El principio de responsabilidad unica:
            //Una clase o componente debe tener una sola responsabilidad unica, sencilla y concreta.

            Beer beer = new Beer("paceña", "cbn");
            BeerDB beerDb = new BeerDB(beer);
            BeerRequest beerRequest= new BeerRequest(beer);

            beerDb.Save();
            beerRequest.Send();
        }
    }
}
