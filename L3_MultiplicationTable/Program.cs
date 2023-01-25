namespace L3_MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter table size:");
            uint tableSize = Convert.ToUInt32(Console.ReadLine());
            for (int i = 1; i <= tableSize; i++)
            {
                for (int j = 1; j <= tableSize; j++)
                {
                    Console.Write(i * j + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}