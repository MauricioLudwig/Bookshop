using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookshop.Data
{
    public static class Lists
    {

        public static List<Print> Prints { get; set; }

        static Lists()
        {
            Prints = new List<Print>()
            {
                new Book() { Author = "Stephen King", Title = "Carrie", Pages = 200, Price = 50, Genre = Book.Genres.Horror },
                new Book() { Author = "Franz Kafka", Title = "The Castle", Pages = 400, Price = 100, Genre = Book.Genres.Surrealism },

                new ComicBook() { Author = "Alan Moore", Artist = "Someone", Pages = 100, Title = "Watchmen", Price = 100 },
                new ComicBook() { Author = "Frank Miller", Artist = "Frank Miller", Pages = 160, Title = "The Dark Knight Returns", Price = 200 },

                new Magazine() { Author = "Caesar", Issue = 1, Pages = 250, Price = 80, Title = "How to Conquer Your Heart" },
                new Magazine() { Author = "Napoleon", Issue = 3, Pages = 300, Price = 200, Title = "How I Lost the Battle at Waterloo" }
            };
        }
    }
}
