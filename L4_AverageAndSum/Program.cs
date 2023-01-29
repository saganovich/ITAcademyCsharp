namespace L4_AverageAndSum
{
    internal class Program
    {
        static bool TryParse(out uint number)
        {
            string sNumber = Console.ReadLine();
            if (UInt32.TryParse(sNumber, out number))
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
                Console.Write("Continue? (Y/N): ");
                if (Console.ReadLine() != "Y") { break; }
                Console.WriteLine();
            }

        }
    }
}