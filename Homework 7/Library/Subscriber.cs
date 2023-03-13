using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
	internal class Subscriber
	{
		public string Name { get; private set; }
		public string Email { get; private set; }
		public List<Genres> Genres { get; set; }
		public Subscriber(string name, string email, List<Genres> genres)
		{
			Name = name;
			Email = email;
			Genres = genres;
		}
		public void Subscribe(Library library)
		{
			library.Subscribe(this);
		}
		public override string ToString()
		{
			return $"Name: {Name}; Email: {Email}";
		}
	}
}
