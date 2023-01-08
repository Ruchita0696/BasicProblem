namespace BasicProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Index of 2 : ");
            int Power = Convert.ToInt32(Console.ReadLine());

            Power power = new Power();
            power.getPowerOf2(Power);
        }
    }
}