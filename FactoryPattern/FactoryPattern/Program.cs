using FactoryPattern.FactoryPattern;
using FactoryPattern.Interfaces;
using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory myFactoryPattern = new Factory();
            IResolve mapper = myFactoryPattern.Get("Hi");
            var mapA = mapper.Resolve();
            Console.WriteLine(mapA.ToString());

            IResolve mapper5 = myFactoryPattern.Get("Bye");
            var mapB = mapper5.Resolve();
            Console.WriteLine(mapB.ToString());

            Console.ReadLine();
        }
    }
}
