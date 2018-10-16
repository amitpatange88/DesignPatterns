using DecoratorPattern.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Decorator
{
    public abstract class CarDecorator : ICar
    {
        private ICar _Car;
        public CarDecorator(ICar Car)
        {
            _Car = Car;
        }

        public string Make => _Car.Make;

        public double GetPrice()
        {
            return _Car.GetPrice();
        }

        public abstract double GetDiscountedPrice();
    }
}
