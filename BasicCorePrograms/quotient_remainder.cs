using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class quotient_remainder
    {
        public static void checkquot_remd()
        {
            Console.WriteLine("Enter divident value");
            int dividend =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter divisor value");
            int divisor = Convert.ToInt32(Console.ReadLine());
           

            int quotient = dividend / divisor;
            int remainder = dividend % divisor;
            Console.WriteLine("Quotient = " + quotient);
            Console.WriteLine("Remainder = " + remainder);
           
        }
    }
}
