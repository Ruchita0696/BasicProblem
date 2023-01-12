namespace BasicProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Number 1 : ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Number 2 : ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Swapnumber swap = new Swapnumber();
            swap.SwappingOfTwoNumbers(num1, num2);
        }
    }
}