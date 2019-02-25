using System;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simple Factory");

            new MyApp(new BalconyFactory());

            Console.ReadKey();
        }
    }
}
