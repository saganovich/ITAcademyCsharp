using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Units
{
	internal class Dragon:Unit,IFly
	{
		public Dragon(string name, int health, int damage)
		{
			Name = name;
			Type = "Dragon";
			Health = health;
			Damage = damage;
		}
		public void Fly()
		{
			Console.WriteLine($"{Type} \"{Name}\" is flying.");
		}
		public override void Say()
		{
			Console.WriteLine($"Arrr!");
		}

	}
}
