using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H5_DoubleArray
{
	internal static class Randomize
	{
		public static int Get()
		{
			Random rnd = new Random();
			return rnd.Next(0, 9);
		}
	}
}
