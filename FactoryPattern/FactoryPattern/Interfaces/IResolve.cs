using System;
using System.Collections.Generic;
using System.Text;
using FactoryPattern.Model;

namespace FactoryPattern.Interfaces
{
    public interface IResolve
    {
        MyObject Resolve();
    }
}
