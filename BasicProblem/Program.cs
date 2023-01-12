namespace BasicProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
            Console.WriteLine("Enter the Index of 2 : ");
            int Power = Convert.ToInt32(Console.ReadLine());

            Power power = new Power();
            power.getPowerOf2(Power);
=======
            Console.WriteLine("Enter the Number For Prime Factor : ");
            int F = Convert.ToInt32(Console.ReadLine());

            Factors factor = new Factors();
            factor.PrimeFactors(F);
>>>>>>> UC5.Factors
=======
            Console.WriteLine("Enter the Year to Check Whether Leap Year or Not : ");
            int yeartoread = Convert.ToInt32(Console.ReadLine());
            LeapYear Year = new LeapYear();
            Year.toCheckLeapYear(yeartoread);
>>>>>>> UC2.LeapYear
=======
            Console.WriteLine("Enter Number : ");
            int H = Convert.ToInt32(Console.ReadLine());

            HarmonicNumber Harmonic = new HarmonicNumber();
            Harmonic.harmonicSeries(H);
>>>>>>> UC4.HarmonicNumber
        }
    }
}