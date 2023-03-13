using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Library
{
	internal class Library
	{
		public string Name { get; private set; }
		private List<Book> Books;
		private List<Subscriber> Subscribers;
		private delegate void BookHandler(Book book);
		private event BookHandler AddBookEv;
		public Library(string name)
		{
			Name = name;
			Books = new List<Book>();
			Subscribers = new List<Subscriber>();
			AddBookEv += Add;
			AddBookEv += SendNotice;
		}
		public delegate void RecBook(Book book);

		public void Subscribe(Subscriber subscriber)
		{
			Subscribers.Add(subscriber);
		}
		private void Add(Book book)
		{
			Books.Add(book);
		}
		public void AddBook(Book book)
		{
			AddBookEv(book);
		}
		private void SendNotice(Book book)
		{
			foreach (Subscriber subscriber in Subscribers)
			{
				if (subscriber.Genres.Exists((x) => x == book.Genre))
				{
					Console.WriteLine($"Send to {subscriber.Email}: \"{CreateNotice(book)}\"");
				}
			}
		}
		private string CreateNotice(Book book)
		{
			return $"{Name} received a book of your favorite genre({book.Genre})!{book}";
		}
	}
}
