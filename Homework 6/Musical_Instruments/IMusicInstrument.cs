using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musical_Instruments
{
	interface IMusicInstrument
	{
		public string Name { get; }
		public string Description { get; }
		public void Sound();

	}
}
