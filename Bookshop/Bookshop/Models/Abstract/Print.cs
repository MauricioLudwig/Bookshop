using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bookshop
{
    public abstract class Print
    {
        public string Author { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public int Pages { get; set; }

        public virtual string PrintParameters()
        {
            return String.Format("{0,-15}{1,-40}{2,-10}{3,-10}",
                "Author",
                "Title",
                "Price",
                "Pages");
        }

        public virtual string PrintValues()
        {
            return String.Format("{0,-15}{1,-40}{2,-10}{3,-10}",
                Author,
                Title,
                Price,
                Pages);
        }
    }
}