namespace L2_Converter
{
	internal class Program
	{
		static void Main(string[] args)
		{
			while (true)
			{
				Console.Write("Enter distance in centimeters: ");
				string distanceCm = Console.ReadLine();
				if (!Double.TryParse(distanceCm, out double distanceM) || distanceM < 0) { Console.WriteLine("Error! The distance must be a positive number.Please try again."); continue; }
				int intDistanceM = (int)(distanceM / 100);
				Console.WriteLine($"There are {intDistanceM} whole meters in {distanceCm} centimeters.");
				Console.WriteLine("Continue? (y/n)");
				if (Console.ReadLine() != "y") { break; }
			}
		}
	}
}