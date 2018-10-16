using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DecoratorPattern.Component;
using DecoratorPattern.Decorator;

namespace DecoratorPattern.ConcreteDecorator
{
    public class Offers : CarDecorator
    {
        public Offers(ICar Car) : base(Car)
        {
        }

        public override double GetDiscountedPrice()
        {
            return .8 * base.GetPrice();
        }
    }
}
