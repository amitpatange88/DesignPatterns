using DecoratorPattern.Component;
using DecoratorPattern.ConcreteComponent;
using DecoratorPattern.ConcreteDecorator;
using DecoratorPattern.Decorator;
using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ICar car = new Audi();
            CarDecorator decorator = new Offers(car);

            string display = string.Format("Make : {0},  Price : {1},  Discounted Price : {2}", decorator.Make, decorator.GetPrice(), decorator.GetDiscountedPrice());

            Console.WriteLine(display);
            Console.ReadLine();
        }
    }
}
