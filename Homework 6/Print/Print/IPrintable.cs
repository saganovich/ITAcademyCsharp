﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Print
{
	internal interface IPrintable
	{
		string Name { get; set; }
		void Print();
	}
}
