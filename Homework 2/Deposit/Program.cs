namespace L3_Deposit
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter deposit amount:");
			if (!Decimal.TryParse(Console.ReadLine(), out decimal depositAmount) || depositAmount <= 0) { PrintError(); return; }
			decimal curDepositAmount = depositAmount;
			Console.WriteLine("Enter amount of month:");
			if (!Int32.TryParse(Console.ReadLine(), out int amountMonth) || amountMonth <= 0) { PrintError(); return; }
			for (int i = 1; i <= amountMonth; i++)
			{
				Console.WriteLine($"During the {i}st month, your deposit was increased by {(curDepositAmount * 0.07M):f2}" +
					$" On your deposit now: {curDepositAmount * 1.07M:f2}");
				curDepositAmount *= 1.07M;
			}
			Console.WriteLine($"TOTAL:\nIn {amountMonth} months your deposit has increased by {(curDepositAmount / depositAmount):p2}\n" +
				$"Deposit amount at the start: {depositAmount:f2}\nFinal deposit amount:{curDepositAmount:f2}");
		}
		static void PrintError()
		{
			Console.WriteLine("Error!");
		}
	}
}