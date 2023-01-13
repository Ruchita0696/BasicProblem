namespace BasicProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("To Find Largest Number Enter Three Numbers Below");
            Console.WriteLine("Enter Number 1 : ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number 2 : ");
            int n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number 3 : ");
            int n3 = Convert.ToInt32(Console.ReadLine());

            LargestNumber largestNumber = new LargestNumber();
            largestNumber.CalculateLargestNumber(n1, n2, n3);
        }
    }
}