﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
   public class Program
    {
        static void Main(string[] args)
        {
            DivNumbers d = new DivNumbers();
            d.division(25, 0);
            d.division(23, 0);
            d.division(25, 5);
            Console.ReadKey();
        }
    }
}
