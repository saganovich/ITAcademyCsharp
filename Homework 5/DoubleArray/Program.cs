namespace DoubleArray
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[,] array = new int[3, 3];
			int[] maxInRow = new int[3];
			for (int i = 0; i < 3; i++)
			{
				int max = int.MinValue;
				for (int j = 0; j < 3; j++)
				{
					array[i, j] = Randomize.Get();
					Console.Write(array[i, j] + " ");
					if(array[i, j] > max) { max = array[i, j]; }
				}
				maxInRow[i] = max;
				Console.WriteLine();
			}
			Console.WriteLine();
			maxInRow.Print();
		}

	}
}