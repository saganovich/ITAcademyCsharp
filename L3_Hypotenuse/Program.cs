namespace L3_Hypotenuse
{
	internal class Program
	{
		static void Main(string[] args)
		{
			while (true)
			{
				Console.WriteLine("Enter the length of the first leg:");

				if (!Double.TryParse(Console.ReadLine(), out double firstLeg) || firstLeg <= 0) { PrintError(); continue; }

				Console.WriteLine("Enter the length of the second leg:");

				if (!Double.TryParse(Console.ReadLine(), out double secondLeg) || secondLeg <= 0) { PrintError(); continue; }

				double hypotenuse = Math.Sqrt(Math.Pow(firstLeg, 2) + Math.Pow(secondLeg, 2));

				Console.WriteLine($"The hypotenuse equals {hypotenuse:f2}");

				break;
			}
			static void PrintError()
			{
				Console.WriteLine("Error!The length of the leg must be a positive integer and not equal to zero");
			}
		}
	}
}
