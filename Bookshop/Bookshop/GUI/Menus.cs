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

        public static void Buy()
        {
            Console.WriteLine("1. Buy");
            Console.WriteLine("2. Show Shopping Cart");
            Console.WriteLine("3. Return");
        }

        public static void Search()
        {
            Console.WriteLine("1. Using LINQ");
            Console.WriteLine("2. Using Delegates");
            Console.WriteLine("3. Return");
        }

        public static void SearchWLINQ()
        {
            Console.WriteLine("1. Order by");
            Console.WriteLine("2. Search by");
            Console.WriteLine("3. Return");
        }

        public static void SearchBy()
        {
            Console.WriteLine("1. Author");
            Console.WriteLine("2. Title");
            Console.WriteLine("3. Price");
            Console.WriteLine("4. Return");
        }

        public static void SearchWDelegates()
        {

        }
    }
}
