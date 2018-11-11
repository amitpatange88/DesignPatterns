using DecoratorPattern.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.ConcreteComponent
{
    public sealed class Audi : ICar
    {
        public string Make => "Sedan";
        //public string Make
        //{
        //    get { return "Audi"; }
        //}

        public double GetPrice()
        {
            return 95000;
        }
    }
}
