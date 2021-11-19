using System;

namespace Solid_L.Antes
{
    public class User : ICrud
    {
        public void Add()
        {
            Console.WriteLine("Add");
        }

        public void Delete()
        {
            Console.WriteLine("Delete");
        }

        public void Get()
        {
            Console.WriteLine("Get");
        }

        public void Update()
        {
            Console.WriteLine("Update");
        }
    }
}
