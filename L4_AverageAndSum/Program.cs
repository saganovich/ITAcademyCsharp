namespace L4_AverageAndSum
{
    internal class Program
    {
        static bool TryParse(out uint number)
        {
            if (UInt32.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine();
                return true;
            }
            else
            {
                Console.WriteLine("Error! You must enter a positive integer. Please try again.\n");
                return false;
            }
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter a:");
                if (!TryParse(out uint a)) { continue; }
                Console.WriteLine("Enter b:");
                if (!TryParse(out uint b)) { continue; }
                if (b < a) { (a, b) = (b, a); }
                uint sum = 0;
                int numCounter = 0;
                for (uint i = a; i <= b; i++)
                {
                    sum += i;
                    numCounter++;
                }
                decimal avg = sum / (decimal)numCounter;
                Console.WriteLine($"Interval [{a};{b}]\nSum = {sum}\nAverage = {Math.Round(avg, 2)}\n");
                Console.Write("Continue? (y/n): ");
                if (Console.ReadLine() != "y") { break; }
                Console.WriteLine();
            }

        }
    }
}