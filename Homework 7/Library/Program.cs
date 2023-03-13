namespace Library
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Создаём подписчиков
			Subscriber sub1 = new Subscriber("Alexander", "alexander@gmail.com", new List<Genres> { Genres.Comedy, Genres.Drama });
			Subscriber sub2 = new Subscriber("Andrey", "andrey@gmail.com", new List<Genres>() { Genres.Horror });
			Subscriber sub3 = new Subscriber("Roman", "roman@gmail.com", new List<Genres>() { Genres.Tragedy, Genres.Comedy });

			//Создаём библиотеки
			Library lib1 = new Library("Library #1");
			Library lib2 = new Library("Library #2");

			//Создаём подписки
			sub1.Subscribe(lib1);
			sub1.Subscribe(lib2);
			sub2.Subscribe(lib1);
			sub3.Subscribe(lib2);

			//Создание книг
			Book book1 = new Book("The Great Gatsby", "F. Scott Fitzgerald", Genres.Tragedy);
			Book book2 = new Book("Catch-22", "Joseph Heller", Genres.Comedy);
			Book book3 = new Book("She Is a Haunting", "Trang Thanh Tran", Genres.Horror);

			//Добавление книг в библиотеки
			lib1.AddBook(book1);
			lib2.AddBook(book2);
			lib1.AddBook(book3);
		}
	}
}