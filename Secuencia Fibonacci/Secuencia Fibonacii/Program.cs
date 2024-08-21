﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secuencia_Fibonacii
{
    class Program
    {
        static void Main(string[] args)
        {   // Obtener la secuencia fibonaccci

            int a = 0, b = 1, c = 1;

            /*
             * 0+1=1
               1+0=1
               1+1=2
               2+1=3
               3+2=5
               5+3=8
               8+5=13
             */

            while (c < 100)
            {
                Console.WriteLine("{0}+{1}={2}", a, b, c);
                b = a;
                a = c;
                c = a + b;

            }

            Console.ReadLine();

        }
    }
}