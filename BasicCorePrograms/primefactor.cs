﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class primefactor
    {
        public static void checkprimefactor()
        {
            Console.WriteLine("Enter number");
            int n = Convert.ToInt32(Console.ReadLine());
           
                while (n % 2 == 0)
                {
                    Console.WriteLine(2 + " ");
                    n /= 2;
                }
                for (int i = 3; i * i <= Math.Sqrt(n); i += 2)
                {
                   
                    while (n % i == 0)
                    {
                        Console.WriteLine(i + " ");
                        n /= i;
                    }
                }
                    if (n > 2)
                    Console.Write(n);
            
        }
    }
}
