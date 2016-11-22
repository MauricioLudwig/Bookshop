using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bookshop
{
    public class Customer
    {
        public List<Print> ShoppingCart { get; set; }

        public Customer()
        {
            ShoppingCart = new List<Print>();
        }
    }
}