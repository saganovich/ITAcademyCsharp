using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print
{
	internal class Book : IPrintable
	{
		public string Name
		{
			get => Name;
			private set => Name = value;
		}
		public string Author
		{
			get => Author;
			private set => Author = value;
		}
		public Book(string name, string author)
		{
			Name = name;
			Author = author;
		}
		public void Print()
		{
			Console.WriteLine(Name);
		}
	}
}
