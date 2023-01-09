namespace BasicProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number For Prime Factor : ");
            int F = Convert.ToInt32(Console.ReadLine());

            Factors factor = new Factors();
            factor.PrimeFactors(F);
        }
    }
}