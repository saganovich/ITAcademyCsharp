using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleArray
{
	internal static class ArrExt
	{
		public static void Print(this int[] arr)
		{
			int columns = arr.GetUpperBound(0) + 1;
			for (int i = 0; i < columns; i++)
			{
				Console.Write(arr[i] + " ");
			}
		}
	}
}
