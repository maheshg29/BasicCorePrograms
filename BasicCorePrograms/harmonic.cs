using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class harmonic
    {
        public static void checkharmonic()
        {
            int i, num;
            double sum = 0;
            Console.WriteLine("Enter the Number for Harmonic series");

            num = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= num; i++)
            {
                Console.WriteLine("1/{0} +", i);
                sum = sum + 1 / (float)i;
            }
            Console.WriteLine("sum of series upto {0} terms :{1}", num, sum);
        }
    }
}
