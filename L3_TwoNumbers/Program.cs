namespace L3_TwoNumbers
{
	internal class Program
	{
		static void Main(string[] args)
		{
			while (true)
			{
				Console.WriteLine("Enter the first number:");
				if (!Int32.TryParse(Console.ReadLine(), out int firstNum) || !Check(firstNum)) { PrintError(); continue; }

				Console.WriteLine("Enter the second number:");
				if (!Int32.TryParse(Console.ReadLine(), out int secondNum) || !Check(secondNum)) { PrintError(); continue; }

				Console.WriteLine($"The product equals {firstNum * secondNum}.");
			}
		}
		static void PrintError()
		{
			Console.WriteLine("Numbers are invalid! Please try again.");
		}
		static bool Check(int num)
		{
			return num >= 0 && num <= 10;
		}
	}
}