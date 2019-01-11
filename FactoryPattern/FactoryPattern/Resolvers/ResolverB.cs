using FactoryPattern.Interfaces;
using FactoryPattern.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Resolvers
{
    public class ResolverB : IResolve
    {
        public MyObject Resolve()
        {
            return new MyObject() { IdValue =99, Name="Simundo" };
        }
    }
}
