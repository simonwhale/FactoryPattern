using System;
using System.Collections.Generic;
using System.Text;
using FactoryPattern.Interfaces;

namespace FactoryPattern.FactoryPattern
{
    public class Factory : ConcreteClass
    {
        public override IResolve Get()
        {
            throw new NotImplementedException();
        }
    }
}
