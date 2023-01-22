namespace L2_Converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter distance in centimeters: ");
                    string distanceCm = Console.ReadLine();
                    int distanceM = (int)(Convert.ToDouble(distanceCm) / 100);
                    Console.WriteLine($"There are {distanceM} whole meters in {distanceCm} centimeters.");
                    Console.WriteLine("Continue? (Y/N)");
                    if (Console.ReadLine() != "Y") { break;}
                }
                catch (Exception ex) { Console.WriteLine("Error! " + ex.Message + " Please try again."); }
            }
        }
    }
}