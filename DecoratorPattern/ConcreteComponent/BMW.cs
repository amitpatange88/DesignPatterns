using DecoratorPattern.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.ConcreteComponent
{
    public sealed class BMW : ICar
    {
        public string Make => "HatchBack";

        public double GetPrice()
        {
            return 70000;
        }
    }
}
