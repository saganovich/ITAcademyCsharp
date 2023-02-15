using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleArray
{
	static class ArrayInt
	{
		public static void SortDesc(this int[] array)
		{
			Array.Sort(array);
			Array.Reverse(array);
		}
		public static void PrintArray(int[] array, int mode)
		{
			switch (mode)
			{
				case 1:
					for (int i = 0; i < array.Length; i++)
					{
						Console.Write(array[i] + " ");
					}
					Console.WriteLine();
					break;
				case 2:
					foreach (int elem in array)
					{
						Console.Write(elem + " ");
					}
					Console.WriteLine();
					break;
			}
		}
		public static void PrintLastElems(int[] array)
		{
			for (int i = array.Length - 3; i < array.Length; i++)
			{
				Console.Write(array[i] + " ");
			}
			Console.WriteLine();
		}
		public static void PrintEvNumberMoreFive(int[] array)
		{
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] > 5 && array[i] % 2 == 0)
				{
					Console.Write(array[i] + " ");
				}
			}
			Console.WriteLine();
		}
	}
}
