using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print
{
	internal class Book : IPrintable
	{
		public string Name { get; set; }
		public string Author { get; set; }
		public Book(string name, string author) { Name = name; Author = author; }
		public void Print() { Console.WriteLine($"Book: {Name}| Author: {Author}"); }
		public static void PrintBooks(IPrintable[] printables)
		{
			foreach (IPrintable printable in printables)
			{
				if (printable is Book) { Console.WriteLine(printable.Name); }
			}
		}
	}
}
