using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musical_Instruments
{
	internal class Piano : IMusicInstrument
	{
		public string Name => "Piano";
		public string Description => "The piano is a stringed keyboard instrument in which the strings " +
										"are struck by wooden hammers that are coated with a softer material.";
		public void Sound()
		{
			Console.WriteLine($"{Name} is playing.{Description}.");
		}
	}
}
