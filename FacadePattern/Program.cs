using ShoppingFacade;
using System;

namespace FacadePattern
{
    /// <summary>
    /// Provides a unified interface to set a of interfaces in a subsystem. Facade defines a higher-lvel interface
    /// that makes subsystem easier to use.
    /// facade =~ frontage or face.
    /// </summary>
    public class Program
    {
        static void Main(string[] args)
        {
            IUserOrder userOrder = new UserOrder();
            Console.WriteLine("Facade : Start");
            Console.WriteLine("************************************");
            int cartID = userOrder.AddToCart(10, 1);
            int userID = 1234;
            Console.WriteLine("************************************");
            int orderID = userOrder.PlaceOrder(cartID, userID);
            Console.WriteLine("************************************");
            Console.WriteLine("Facade : End CartID = {0}, OrderID = {1}",
                cartID, orderID);
            Console.ReadLine();
        }
    }
}
