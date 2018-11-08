using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Interfaces
{
    public interface IWallet
    {
        double GetUserBalance(int userID);
    }
}
