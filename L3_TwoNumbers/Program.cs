namespace L3_TwoNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter the first number:");
                int firstNum = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the second number:");
                int secondNum = Convert.ToInt32(Console.ReadLine());

                if (firstNum >= 0 && firstNum <= 10 && secondNum >= 0 && secondNum <= 10)
                {
                    Console.WriteLine($"The product equals {firstNum * secondNum}.");
                    break;
                }
                Console.WriteLine("Numbers are invalid! Please try again.");
            }
        }
    }
}