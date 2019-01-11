using FactoryPattern.Interfaces;
using FactoryPattern.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Resolvers
{
    public class ResolverA : IResolve
    {
        public MyObject Resolve()
        {
            return new MyObject() { IdValue = 1, Name = "Simon" };
        }

    }
}
