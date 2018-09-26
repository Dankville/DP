using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
	class TurkeyAdapter : Duck
	{
		Turkey _Turkey;

		public TurkeyAdapter(Turkey turkey)
		{
			this._Turkey = turkey;
		}
		
		public void Fly()
		{
			for (int i = 0; i < 5; i++)
			{
				_Turkey.Fly();
			}
		}

		public void Quack()
		{
			_Turkey.Gobble();
		}
	}
}
