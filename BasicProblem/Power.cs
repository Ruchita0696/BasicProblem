using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblem
{
    public class Power
    {
        public void getPowerOf2(int num)
        {
            int a = 1;
            int b = 0;
            for (int i = 0; i < num; i++)
            {
                if (num >= 31)
                {
                    Console.WriteLine("Value is ouf of Int Limit");
                    break;
                }
                num = (2 * a);
                a = num;
                b++;
                Console.WriteLine("2 to the Power of " + b + " is : " + num);
            }
        }
    }
}
