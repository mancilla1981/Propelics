﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 200; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                    continue;
                }
                if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                    continue;
                }
                if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                    continue;
                }
                Console.WriteLine(i);
 
            }
            Console.ReadLine();

        }
    }
}
