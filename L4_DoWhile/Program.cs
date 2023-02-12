namespace L4_DoWhile
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int curNum = -20;
			do
			{
				Console.WriteLine(curNum);
				curNum -= 20;
			}
			while (curNum > -100);
		}
	}
}