namespace Musical_Instruments
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<IMusicInstrument> instruments = new List<IMusicInstrument>() { new Guitar(), new Piano(), new Violin() };
			foreach (IMusicInstrument instrument in instruments)
			{
				instrument.MakeSound();
			}
		}
	}
}