using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblem
{
    public class LargestNumber
    {
        public void CalculateLargestNumber(int Num1, int Num2, int Num3)
        {
            if (Num1 > Num2 && Num1 > Num3)
            {
                Console.WriteLine(Num1 + " is Largest Amoung All ");
            }
            else if (Num2 > Num3 && Num2 > Num3)
            {
                Console.WriteLine (Num2 + " is Largest Amoung All ")
            }
            else
            {
                Console.WriteLine(Num3 + " is Largest Amoung All");
            }
        }
    }
}
