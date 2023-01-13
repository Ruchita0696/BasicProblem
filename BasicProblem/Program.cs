namespace BasicProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Divident : ");
            int Di = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Divisor : ");
            int Dv = Convert.ToInt32(Console.ReadLine());

            QuotientReminder Qr = new QuotientReminder();
            Qr.Calculation(Di, Dv);
        }
    }
}