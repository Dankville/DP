using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator.Beverages;

namespace Decorator.CondimentDecorators
{
	public class Soy : CondimentDecorator
	{
		Beverage Beverage;
		
		public Soy(Beverage bev)
		{
			Beverage = bev;
		}

		public override string GetDescription()
		{
			return Beverage.GetDescription() + ", Soy";
		}

		public override double Cost() => Beverage.Cost() + .15;
	}
}
