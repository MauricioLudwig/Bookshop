using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bookshop.Data;

namespace Bookshop
{
    public class BookRepository : IStoreRepository
    {
        public void Add(Print newPrint)
        {
            Lists.Prints.Add(newPrint);
        }

        public Print GetSingle(int index)
        {
            return Lists.Prints[index - 1];
        }

        public List<Print> GetAll()
        {
            return Lists.Prints;
        }

        public void Delete(int index)
        {
            Lists.Prints.RemoveAt(index - 1);
        }
    }
}