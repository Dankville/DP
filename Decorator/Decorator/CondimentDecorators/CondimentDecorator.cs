﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator.Beverages;

namespace Decorator.CondimentDecorators
{
	public abstract class CondimentDecorator : Beverage
	{
		public override string GetDescription() => base.GetDescription();
	}
}
