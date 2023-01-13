namespace BasicProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number to Check Even or Odd: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            

            EvenandOdd evenorodd = new EvenandOdd();
            evenorodd.checkEvenOdd(num1);
        }
    }
}