using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator.Beverages;

namespace Decorator.CondimentDecorators
{
	public class Whip : CondimentDecorator
	{
		Beverage Beverage;

		public Whip(Beverage bev)
		{
			Beverage = bev;
		}

		public override string GetDescription()
		{
			return Beverage.GetDescription() + ", Whip";
		}

		public override double Cost()
		{
			return Beverage.Cost() + .10;
		}
	}
}
