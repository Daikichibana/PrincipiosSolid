using System;

namespace Solid_L.Despues
{
    //Solo necesito que se pueda obtener.
    public class Car : IGet
    {
        public void Get()
        {
            Console.WriteLine("Get");
        }
    }
}
