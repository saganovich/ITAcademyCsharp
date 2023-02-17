using System.Text.RegularExpressions;

namespace FileName
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string path = @"c:\WebServers\home\testsite\www\hello\myfile.txt";
			Regex regex = new Regex(@"\w*[.]\w*$");
			Console.WriteLine(regex.Match(path));
		}
	}
}