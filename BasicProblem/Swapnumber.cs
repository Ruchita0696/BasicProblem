using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblem
{
    public class Swapnumber
    {
        public void SwappingOfTwoNumbers(int Number1, int Number2)
        {
            int Number3 = Number1;
            Number1 = Number2;
            Number2 = Number3;

            Console.WriteLine("Number 1 is : " + Number1);
            Console.WriteLine("Number 2 is : " + Number2);
        }
    }
}
