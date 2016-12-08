using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bookshop.GUI;

namespace Bookshop.Managers
{
    class PrintManager
    {

        private BookRepository bookRepo = new BookRepository();
        private Customer customer = new Customer();

        public void Buy()
        {
            ShowAll();
            int index = UI.SelectPrint();
            customer.ShoppingCart.Add(bookRepo.GetSingle(index));
        }

        public void ShowCart()
        {
            customer.ShowShoppingCart();
        }

        public void Add()
        {
            var newPrint = UI.AddPrint();
            bookRepo.Add(newPrint);
        }

        public void Delete()
        {
            ShowAll();
            int index = UI.SelectPrint();
            bookRepo.Delete(index);
        }

        public void ShowAll()
        {
            UI.PrintBooks(bookRepo.GetAll());
        }
    }
}
