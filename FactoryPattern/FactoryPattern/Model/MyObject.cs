using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern.Model
{
    public sealed class MyObject
    {
        public int IdValue { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"idValue: {IdValue}, Name: {Name}";
        }
    }
}
