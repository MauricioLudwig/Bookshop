using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Bookshop.GUI;
using Bookshop.Managers;

namespace Bookshop
{
    class Client
    {

        private PrintManager printMgr = new PrintManager();

        public void Start()
        {

            bool loop = true;

            while (loop)
            {

                Console.Clear();
                Menus.Start();
                var input = Console.ReadKey(true).Key;

                switch (input)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        printMgr.Buy();
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        printMgr.Add();
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        printMgr.Delete();
                        break;
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        // Search
                        break;
                    case ConsoleKey.D5:
                    case ConsoleKey.NumPad5:
                        printMgr.ShowAll();
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D6:
                    case ConsoleKey.NumPad6:
                        loop = false;
                        break;
                }
            }

        }
    }
}
