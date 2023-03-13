using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
	internal class Book
	{
		public string Title { get; private set; }
		public string Author { get; private set; }
		public Genres Genre { get; private set; }
		public Book(string title, string author, Genres genre)
		{
			Title = title;
			Author = author;
			Genre = genre;
		}
		public override string ToString()
		{
			return $"\"{Title}\",{Author}";
		}
	}
}
