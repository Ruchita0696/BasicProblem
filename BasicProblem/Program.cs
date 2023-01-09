namespace BasicProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}