using System;

namespace SimpleFactory
{
    class BalconyType1 : IBalcony
    {
        public void GetName()
        {
            Console.WriteLine("Balcony 1");
        }
    }
}
