using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblem
{
    public class Factors
    {
        public void PrimeFactors(int Number)
        {
            int Factor;
            for (Factor = 2; Number > 1; Factor++)
            {
                if (Number % Factor == 0)
                {
                    int Times = 0;
                    while (Number % Factor == 0)
                    {
                        Number = Number / Factor;
                        Times++;
                    }
                    Console.WriteLine(Factor + " is Prime Factor " + Times + " times ");
                }
            }
        }
    }
}
