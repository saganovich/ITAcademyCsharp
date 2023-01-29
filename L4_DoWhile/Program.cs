namespace L4_DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int curNum = 0;
            do
            {
                curNum -= 20;
                Console.WriteLine(curNum);
            } 
            while (curNum > -100);
        }
    }
}