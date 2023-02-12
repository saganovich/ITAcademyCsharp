namespace H5_SingleArray
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] array = new int[6];
			for (int i = 0; i < array.Length; i++)
			{
				while (!InputValue(i, out array[i])) ;
			}
			ArrayInt.SortDesc(array);
			ArrayInt.PrintArray(array, 1);
			ArrayInt.PrintArray(array, 2);
			ArrayInt.PrintLastElems(array);
			ArrayInt.PrintEvNumberMoreFive(array);
		}

		static bool InputValue(int index, out int value)
		{
			Console.Write($"Enter array[{index}]:");
			if (Int32.TryParse(Console.ReadLine(), out value))
			{
				return true;
			}
			else
			{
				Console.WriteLine("Error!An integer value was expected.Please try again");
				return false;
			}
		}
	}
}