using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator.Beverages;

namespace Decorator.CondimentDecorators
{
	public class Mocha : CondimentDecorator
	{
		Beverage Beverage;

		public Mocha(Beverage bev)
		{
			Beverage = bev;
		}

		public override string GetDescription()
		{
			return Beverage.GetDescription() + ", Mocha";
		}

		public override double Cost() => .20 + Beverage.Cost();
	}
}
