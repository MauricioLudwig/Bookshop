using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookshop.GUI
{
    class Menus
    {
        public static void Start()
        {
            Console.WriteLine("1. Buy");
            Console.WriteLine("2. Add");
            Console.WriteLine("3. Delete");
            Console.WriteLine("4. Search");
            Console.WriteLine("5. Show All");
            Console.WriteLine("6. Exit");
        }

        public static int PrintCategory()
        {
            Console.WriteLine();
            Console.WriteLine("1. Book");
            Console.WriteLine("2. Comic Book");
            Console.WriteLine("3. Magazine");

            Console.Write("\nCategory: ");
            int index = int.Parse(Console.ReadLine());
            Console.WriteLine();

            return index;
        }
    }
}
