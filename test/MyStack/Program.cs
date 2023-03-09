namespace MyStack
{
	internal class Program
	{
		static void Main(string[] args)
		{
            Console.WriteLine("Создание int стека..");
            MyStack<int> stack = new MyStack<int>();
			Console.WriteLine($"Размер стека : {stack.Size}");
            Console.WriteLine("Добавление 10 в стек");
            stack.Push(10);
			Console.WriteLine("Добавление 20 в стек");
			stack.Push(20);
			Console.WriteLine("Добавление 30 в стек");
			stack.Push(30);
			Console.WriteLine("Добавление 40 в стек");
			stack.Push(40);
			Console.WriteLine("Добавление 50 в стек");
			stack.Push(50);
			Console.WriteLine($"Данные в стеке: {stack}");
			Console.WriteLine($"Размер стека : {stack.Size}");
			Console.WriteLine($"Просмотр первого элемента стека: {stack.Peek()}");
			Console.WriteLine($"Размер стека : {stack.Size}");
			Console.WriteLine($"Извлечение первого элемента стека: {stack.Pop()}");
			Console.WriteLine($"Данные в стеке: {stack}");
			Console.WriteLine($"Извлечение первого элемента стека: {stack.Pop()}");
			Console.WriteLine($"Извлечение первого элемента стека: {stack.Pop()}");
			Console.WriteLine($"Извлечение первого элемента стека: {stack.Pop()}");
			Console.WriteLine($"Извлечение первого элемента стека: {stack.Pop()}");
			Console.WriteLine($"Данные в стеке: {stack}");
		}
	}
}