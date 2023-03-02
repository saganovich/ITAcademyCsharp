namespace Print
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Book book1 = new Book("Grokking Algorithms", "Aditya Bhargava");
			Book book2 = new Book("Clean Code", "Robert C. Martin");
			Magazine magazine1 = new Magazine("MIT Technology Review", "Elizabeth Bramson-Boudreau");
			Magazine magazine2 = new Magazine("Wired", "Condé Nast Publishing");
			IPrintable[] printables = new IPrintable[] { book1, book2, magazine1, magazine2 };
			Console.WriteLine("All in array:");
			foreach (IPrintable printable in printables)
			{
				printable.Print();
			}
			Console.WriteLine("\nBooks:");
			Book.PrintBooks(printables);
			Console.WriteLine("\nMagazines:");
			Magazine.PrintMagazines(printables);

		}
	}
}