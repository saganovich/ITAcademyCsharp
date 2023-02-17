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
			Console.WriteLine($"string.Split result: {words.Length}");
			Regex regex = new Regex(@"\w+\s*");
			MatchCollection mCol = regex.Matches(text);
			Console.WriteLine($"Regex.Matches result: {words.Length}");

		}
	}
}