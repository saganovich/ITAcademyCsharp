using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musical_Instruments
{
	internal class Guitar : IMusicInstrument
	{
		public string Name => "Guitar";
		public string Description => "The guitar is a fretted musical instrument that typically has six strings.";
		public void Sound()
		{
			Console.WriteLine($"{Name} is playing.{Description}.");
		}
	}
}
