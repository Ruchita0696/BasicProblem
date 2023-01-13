using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblem
{
    public class EvenandOdd
    {
        public void checkEvenOdd(int Number)
        {
            if (Number % 2 == 0)
            {
                Console.WriteLine(Number + " is an Even Number ");
            }
            else
            {
                Console.WriteLine(Number + " is an odd Number ");
            }
        }
    }
}
