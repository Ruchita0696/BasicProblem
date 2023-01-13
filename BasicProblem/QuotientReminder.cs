using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblem
{
    public class QuotientReminder
    {
        public void Calculation(int dividend, int divisor)
        {
            int quotient = dividend / divisor;
            int remainder = dividend % divisor;
            
               Console.WriteLine("Quotient is : " + quotient);
                Console.WriteLine("Remainder is : " + remainder);
            
        }
    }
}
