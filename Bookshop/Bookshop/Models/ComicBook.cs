using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bookshop
{
    public class ComicBook : Print
    {
        public string Artist { get; set; }

        public override string PrintParameters()
        {
            return String.Format("{0,-15}{1,-15}",
                base.PrintParameters(),
                "Artist");
        }

        public override string PrintValues()
        {
            return String.Format("{0,-15}{1,-15}",
                base.PrintValues(),
                Artist);
        }
    }
}