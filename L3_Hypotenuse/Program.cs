namespace L3_Hypotenuse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter the length of the first leg:");

                    double firstLeg = Convert.ToDouble(Console.ReadLine());

                    if (firstLeg < 0) { throw new Exception("Number must be positive."); }

                    Console.WriteLine("Enter the length of the second leg:");

                    double secondLeg = Convert.ToDouble(Console.ReadLine());

                    if (secondLeg < 0) { throw new Exception("Number must be positive."); }
                    
                    double hypotenuse = Math.Round(Math.Sqrt(Math.Pow(firstLeg, 2) + Math.Pow(secondLeg, 2)), 3);

                    Console.WriteLine($"The hypotenuse equals {hypotenuse}.");

                    break;
                }
                catch (Exception ex) { Console.WriteLine("Error! " + ex.Message + " Please try again."); }
            }
        }
    }
}
