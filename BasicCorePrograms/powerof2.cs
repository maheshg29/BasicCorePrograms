using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class powerof2
    {
        public static void powerof2table()
        {
            Console.WriteLine("Enter the number for power of 2 table");
            int num = Convert.ToInt32(Console.ReadLine());
            double pow;
            for (int i = 1; i <= num; i++)
            {
                pow = Math.Pow(2, i);
                Console.WriteLine(pow);
            }
        }
    }
}
