using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class odd_even
    {
        public static void check_odd_even()
        {
            
            Console.Write("Enter a Number : ");
            int i = Convert.ToInt32(Console.ReadLine());
            if (i % 2 == 0)
                Console.Write("Entered Number is an Even Number");
            
            else
                Console.Write("Entered Number is an Odd Number");
              
        }
    }
}
