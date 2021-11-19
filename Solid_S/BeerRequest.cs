using System;

namespace Solid_S
{
    public class BeerRequest
    {
        public Beer _beer;

        public BeerRequest(Beer beer)
        {
            this._beer = beer;
        }

        public void Send()
        {
            Console.WriteLine($"Enviamos: {_beer.name} y {_beer.brand}.");
        }
    }
}
