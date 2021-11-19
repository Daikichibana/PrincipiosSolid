using System;

namespace Solid_S
{
    public class BeerDB
    {
        Beer _beer;

        public BeerDB(Beer beer)
        {
            this._beer = beer;
        }

        public void Save()
        {
            Console.WriteLine($"Guardamos: {_beer.name} y {_beer.brand}.");
        }
    }
}
