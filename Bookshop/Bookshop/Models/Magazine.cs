using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bookshop
{
    public class Magazine : Print
    {
        public int Issue { get; set; }

        public override string PrintParameters()
        {
            return String.Format("{0,-15}{1,-15}",
                base.PrintParameters(),
                "Issue");
        }

        public override string PrintValues()
        {
            return String.Format("{0,-15}{1,-15}",
                base.PrintValues(),
                Issue);
        }
    }
}