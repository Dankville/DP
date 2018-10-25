using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator.Beverages;

namespace Decorator.CondimentDecorators
{
	class SteamedMilk : CondimentDecorator
	{
		Beverage Beverage;

		public SteamedMilk(Beverage bev)
		{
			Beverage = bev;
		}

		public override string GetDescription()
		{
			return Beverage.GetDescription() + ", Steamed Milk";
		}


		public override double Cost() => Beverage.Cost() + .10;
	}
}
