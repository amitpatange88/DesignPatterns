using ShoppingCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Interfaces
{
    public interface ICart
    {
        Product GetItemDetails(int itemID);
        bool CheckItemAvailability(Product product);
        bool LockItemInStock(int itemID, int quantity);
        int AddItemToCart(int itemID, int quantity);
        double GetCartPrice(int cartID);
    }
}
