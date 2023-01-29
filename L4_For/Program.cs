namespace L4_For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 10; i < 100; i++)
            {
                if (i % 5 == 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}