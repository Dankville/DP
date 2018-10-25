using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Beverages
{
	public abstract class Beverage
	{
		protected string Description = "Unknown Bevarage";

		public virtual string GetDescription() => Description;

		public abstract double Cost();

	}
}
