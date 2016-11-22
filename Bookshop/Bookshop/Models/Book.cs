using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bookshop
{
    public class Book : Print
    {

        public Genres Genre { get; set; }

        public enum Genres
        {
            Horror = 1,
            Fantasy,
            SciFi,
            Dystopia,
            Family,
            Adventure,
            Action,
            Surrealism
        }

        public override string PrintParameters()
        {
            return String.Format("{0,-15}{1,-15}",
                base.PrintParameters(),
                "Genre");
        }

        public override string PrintValues()
        {
            return String.Format("{0}{1}",
                base.PrintValues(),
                Genre);
        }
    }
}