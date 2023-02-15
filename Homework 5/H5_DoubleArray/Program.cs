namespace H5_DoubleArray
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[,] array = new int[3, 3];
			for (int i = 0; i < 3; i++)
			{
				for (int j = 0; j < 3; j++)
				{
					array[i, j] = Randomize.Get();
				}
			}
			array.PrintArray();
			Console.WriteLine();
			for(int i = 0; i < 3; i++)
			{
				Console.Write(array.GetMaxInRow(i)+" ");
			}


		}

	}
}