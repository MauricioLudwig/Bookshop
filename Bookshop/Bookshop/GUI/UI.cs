using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookshop.GUI
{
    class UI
    {

        public static Print AddPrint()
        {
            var category = Menus.PrintCategory();

            string author;
            string title;
            int price;
            int pages;

            GetCommonAttributes(out author, out title, out price, out pages);

            switch (category)
            {
                case 1:

                    Book newBook = new Book() { Author = author, Title = title, Pages = pages, Price = price };

                    Console.Write("Select genre");
                    newBook.Genre = GetBookGenre();

                    return newBook;

                case 2:

                    ComicBook newComicBook = new ComicBook() { Author = author, Title = title, Pages = pages, Price = price };

                    Console.Write("Artist: ");
                    newComicBook.Artist = Console.ReadLine();

                    return newComicBook;

                case 3:

                    Magazine newMagazine = new Magazine() { Author = author, Title = title, Pages = pages, Price = price };

                    Console.Write("Issue: ");
                    newMagazine.Issue = int.Parse(Console.ReadLine());

                    return newMagazine;

                default:
                    return null;
            }
        }

        private static Book.Genres GetBookGenre()
        {
            foreach (var singleEnum in Enum.GetValues(typeof(Book.Genres)))
            {
                Console.WriteLine("{0}. {1}", (int)singleEnum, singleEnum);
            }

            int index = int.Parse(Console.ReadLine());

            return (Book.Genres)index;
        }

        private static void GetCommonAttributes(out string author, out string title, out int price, out int pages)
        {
            Console.Write("Author: ");
            author = Console.ReadLine();

            Console.Write("Title: ");
            title = Console.ReadLine();

            Console.Write("Price: ");
            price = int.Parse(Console.ReadLine());

            Console.Write("Pages: ");
            pages = int.Parse(Console.ReadLine());
        }


        public static void PrintBooks(List<Print> prints)
        {

            Console.WriteLine("\n--------------------\n");
            int index = 1;

            foreach (var print in prints)
            {
                Console.WriteLine("{0,-10}{1}",
                    "Index",
                    print.PrintParameters());

                Console.WriteLine("{0,-10}{1}",
                    index++,
                    print.PrintValues());

                Console.WriteLine();
            }
        }

        public static int SelectPrint()
        {
            Console.Write(Environment.NewLine + "Index: ");
            int index = int.Parse(Console.ReadLine());
            return index;
        }
    }
}
