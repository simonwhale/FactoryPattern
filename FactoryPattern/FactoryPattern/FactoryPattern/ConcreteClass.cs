using System;
using System.Collections.Generic;
using System.Text;
using FactoryPattern.Interfaces;

namespace FactoryPattern.FactoryPattern
{
    public abstract class ConcreteClass
    {
        public abstract IResolve Get(string value);
    }
}
