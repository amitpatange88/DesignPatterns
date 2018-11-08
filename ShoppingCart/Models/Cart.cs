﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Models
{
    public class Cart
    {
        public int CartID { get; set; }
        public int UserID { get; set; }
        public IEnumerable<CartItem> ShoppingCart { get; set; }
    }
}
