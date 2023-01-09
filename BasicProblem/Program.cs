namespace BasicProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number : ");
            int H = Convert.ToInt32(Console.ReadLine());

            HarmonicNumber Harmonic = new HarmonicNumber();
            Harmonic.harmonicSeries(H);
        }
    }
}