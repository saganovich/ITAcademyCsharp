using System.Text;
using System.Text.RegularExpressions;

namespace WordCounter
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string text = Console.ReadLine();
			char[] marks = { ' ', ',', '.', '-', ':', ';', '!', '?' };
			string[] words = text.Split(marks, StringSplitOptions.RemoveEmptyEntries);
			Console.WriteLine(words.Length);
		}
	}
}