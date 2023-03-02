using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print
{
	internal class Magazine : IPrintable
	{
		public string Name { get; set; }
		public string Publisher { get; set; }
		public Magazine(string name, string publisher) { Name = name; Publisher = publisher; }
		public void Print() { Console.WriteLine($"Magazine: {Name}| Publisher: {Publisher}"); }
		public static void PrintMagazines(IPrintable[] printables)
		{
			foreach (IPrintable printable in printables)
			{
				if (printable is Magazine) { Console.WriteLine(printable.Name); }
			}
		}
	}
}
