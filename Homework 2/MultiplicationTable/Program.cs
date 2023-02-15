namespace L3_MultiplicationTable
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter table size:");
			if (!ushort.TryParse(Console.ReadLine(), out ushort tableSize)) { Console.WriteLine("Error!");return; }
			for (ushort i = 1; i <= tableSize; i++)
			{
				for (ushort j = 1; j <= tableSize; j++)
				{
					Console.Write(i * j + "\t");
				}
				Console.WriteLine();
			}
		}
	}
}