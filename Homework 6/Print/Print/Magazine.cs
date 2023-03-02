using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print
{
	internal class Magazine : IPrintable
	{
		public string Name
		{
			get => Name;
			private set => Name = value;
		}
		public string Publisher
		{
			get => Publisher;
			private set => Publisher = value;
		}
		public Magazine(string name, string publisher)
		{
			Name = name;
			Publisher = publisher;
		}
		public void Print()
		{
			Console.WriteLine(Name);
		}
	}
}
