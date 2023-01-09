namespace BasicProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Year to Check Whether Leap Year or Not : ");
            int yeartoread = Convert.ToInt32(Console.ReadLine());
            LeapYear Year = new LeapYear();
            Year.toCheckLeapYear(yeartoread);
        }
    }
}