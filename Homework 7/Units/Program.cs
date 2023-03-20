namespace Units
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Human human = new Human("Person", 100, 20);
			Dragon dragon = new Dragon("Pazhiloi drakon", 500, 130);
			Troll troll = new Troll("Trolik", 150, 80);
			List<Unit> units = new List<Unit>() { human, dragon, troll };
			foreach(Unit unit in units)
			{
				unit.Move();
				unit.Say();
			}
			List <ISwim> swimList = new List<ISwim>() { human,troll};
			foreach(ISwim s in swimList)
			{
				s.Swim();
			}
		}
	}
}