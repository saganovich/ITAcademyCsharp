using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Units
{
	internal class Human : Unit, IJump, ISwim
	{
		public Human(string name, int health, int damage)
		{
			Name = name;
			Type = "Human";
			Health = health;
			Damage = damage;
		}
		public void Jump()
		{
			Console.WriteLine($"{Type} \"{Name}\" is jumping.");
		}
		public void Swim()
		{
			Console.WriteLine($"{Type} \"{Name}\" is swimming.");
		}
		public override void Say()
		{
			Console.WriteLine($"Hello!");
		}
	}
}
