using System;
using System.Collections.Generic;
using System.Text;
using FactoryPattern.Interfaces;

namespace FactoryPattern.FactoryPattern
{
    public class Factory : ConcreteClass
    {
        public override IResolve Get(string value)
        {
            IResolve mapper = null;
            switch(value)
            {
                case "Hi":
                    mapper =  new Resolvers.ResolverA();
                    break;
                case "Bye":
                    mapper = new Resolvers.ResolverB();
                    break;
            }

            return mapper;
        }
    }
}
