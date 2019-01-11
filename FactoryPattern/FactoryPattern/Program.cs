using FactoryPattern.FactoryPattern;
using FactoryPattern.Interfaces;
using FactoryPattern.Model;
using FactoryPattern.Resolvers;
using System;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteClass abstractFactory = new Factory();
            IResolve mapA = abstractFactory.Get("Hi");
            MyObject resolverA = mapA.Resolve();
            Console.WriteLine(resolverA.ToString());

            IResolve mapB = abstractFactory.Get("Bye");
            MyObject resolverB = mapB.Resolve();
            Console.WriteLine(resolverB);
            Console.ReadLine();
        }
    }
}
