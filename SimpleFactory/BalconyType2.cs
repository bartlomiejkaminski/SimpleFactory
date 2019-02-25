using System;

namespace SimpleFactory
{
    class BalconyType2 : IBalcony
    {
        public void GetName()
        {
            Console.WriteLine("Balcony 2");
        }
    }
}
