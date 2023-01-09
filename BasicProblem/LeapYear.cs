using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblem
{
    public class LeapYear
    {
        public void toCheckLeapYear(int year)
        {

            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        Console.WriteLine("Its a Leap Year");
                    }
                    else
                    {
                        Console.WriteLine("Its not a Leap Year");

                    }
                }
                else
                {
                    Console.WriteLine("Its a Leap Year");
                }
            }
            else
            {
                Console.WriteLine("Its not a Leap Year");
            }
        }
    }
}
