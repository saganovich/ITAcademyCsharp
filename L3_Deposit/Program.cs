namespace L3_Deposit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter deposit amount:");
            decimal depositAmount = Convert.ToDecimal(Console.ReadLine());
            decimal curDepositAmount = depositAmount;
            Console.WriteLine("Enter amount of month:");
            int amountMonth = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= amountMonth; i++)
            {
                Console.WriteLine($"During the {i}st month, your deposit was increased by {Math.Round(curDepositAmount * 0.07M,2)}. On your deposit now: {Math.Round(curDepositAmount * 1.07M,2)}.");
                curDepositAmount *= 1.07M;
            }
            Console.WriteLine($"TOTAL:\nIn {amountMonth} months your deposit has increased by {Math.Round(curDepositAmount*100M/depositAmount-100M,2)} percent.\nDeposit amount at the start: {Math.Round(depositAmount,2)}.\nFinal deposit amount:{Math.Round(curDepositAmount,2)}.");
        }
    }
}