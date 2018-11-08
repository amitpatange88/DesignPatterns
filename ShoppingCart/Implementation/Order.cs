using ShoppingCart.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Implementation
{
    public class Order : IOrder
    {
        public int PlaceOrderDetails(int cartID, int shippingAddressID)
        {
            Console.WriteLine("\t SubSystem Order : PlaceOrderDetails");
            return 10;
        }
    }
}
