using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bookshop
{
    public interface IStoreRepository
    {
        void Add(Print newPrint);
        Print GetSingle(int index);
        List<Print> GetAll();
        void Delete(int index);
    }
}