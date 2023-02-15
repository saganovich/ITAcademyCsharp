using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleArray
{
	internal static class DblArrExt
	{
		public static void PrintArray(this int[,] arr)
		{
			int rows = arr.GetUpperBound(0) + 1;
			int columns = arr.GetUpperBound(1) + 1;
			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < columns; j++)
				{
					Console.Write(arr[i, j] + " ");
				}
				Console.WriteLine();
			}
		}

		public static int GetMaxInRow(this int[,] arr,int numRow)
		{
			int columns = arr.GetUpperBound(1) + 1;
			int max = int.MinValue;
			for(int j = 0; j < columns; j++)
			{
				if(arr[numRow,j]>max) { max = arr[numRow, j]; }
			}
			return max;
		}
	}
}
