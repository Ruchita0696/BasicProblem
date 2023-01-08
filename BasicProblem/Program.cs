namespace BasicProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter How Many Times You Have to Flip a Coin : ");
            int C = Convert.ToInt32(Console.ReadLine());

            FlipCoin coin = new FlipCoin();
            coin.getPercentageOfFlipCion(C);
        }
    }
}