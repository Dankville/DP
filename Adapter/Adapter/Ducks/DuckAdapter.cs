using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
	class DuckAdapter : Turkey
	{
		Duck _Duck;

		public DuckAdapter(Duck duck)
		{
			_Duck = duck;
		}

		public void Fly()
		{
			_Duck.Fly();
		}

		public void Gobble()
		{
			_Duck.Quack();
		}
	}
}
