using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class flipcoin
    {
        public static void toss()
        {
            int count = 0,head=0,tail=0,rand;
            double headpersentage,tailpersentage;
            Console.WriteLine("Enter the Count you want to toss");
            count=Convert.ToInt32(Console.ReadLine());
            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    Random random = new Random();
                    rand = random.Next(2);

                    if (rand == 0)
                    {
                        head++;
                        Console.WriteLine("Head" + head);
                    }
                    else if (rand == 1)
                    {
                        tail++;
                        Console.WriteLine("tail"+tail);
                    }
                }

                headpersentage = ((float)(head / count) * 100);
                tailpersentage = ((float)(tail / count) * 100);

                Console.WriteLine("Head percentage is : " + headpersentage);
                Console.WriteLine("Tail percentage is :" + tailpersentage);

            }
            else
            {
                Console.WriteLine("Please Enter valid number");
            }
        }
    }
}
