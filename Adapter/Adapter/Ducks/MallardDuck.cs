﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
	class MallardDuck : Duck
	{
		public void Fly()
		{
			Console.WriteLine("I'm Flying.");
		}

		public void Quack()
		{
			Console.WriteLine("Quack.");
		}
	}
}
