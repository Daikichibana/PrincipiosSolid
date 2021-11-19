using System;

namespace Solid_L.Antes
{
    //Solo necesito que se pueda obtener.
    public class Car : ICrud
    {
        public void Add()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Get()
        {
            Console.WriteLine("Add");
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
