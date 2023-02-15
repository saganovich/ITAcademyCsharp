namespace L4_AverageAndSum
{
	internal class Program
	{
		static bool TryParse(string numb, out uint number)
		{
			Console.WriteLine($"Enter {numb}:");
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
				uint b = 0;
				if (!TryParse("a", out uint a) || !TryParse("b", out b)) { continue; }
				if (b < a) { (a, b) = (b, a); }
				uint sum = 0;
				int numCounter = 0;
				for (uint i = a; i <= b; i++)
				{
					sum += i;
					numCounter++;
				}
				double avg = sum / (double)numCounter;
				Console.WriteLine($"Interval [{a};{b}]\nSum = {sum}\nAverage = {avg:f2}\n");
				Console.Write("Continue? (y/n): ");
				if (Console.ReadLine() != "y") { break; }
				Console.WriteLine();
			}

		}
	}
}