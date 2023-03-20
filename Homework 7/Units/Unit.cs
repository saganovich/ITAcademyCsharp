using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Units
{
	abstract class Unit
	{
		public string Name { get;internal set; }
		public string Type { get; internal set; }
		public int Health { get; internal set; }
		public int Damage { get; internal set; }

		public virtual void Move()
		{
			Console.WriteLine($"{Type} \"{Name}\" is moving.");
		}
		public abstract void Say();

	}
}
