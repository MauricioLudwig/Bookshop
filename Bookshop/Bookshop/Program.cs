﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookshop
{
    class Program
    {
        static void Main(string[] args)
        {
            var client = new Client();
            client.Start();

            Console.ReadKey();
        }
    }
}
