using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Pizzas
{
	public abstract class Pizza
	{
		public void Prepare()
		{
			Console.WriteLine("Preparing pizza.");
		}

		public void Bake()
		{
			Console.WriteLine("Baking pizza");
		}

		public void Cut()
		{
			Console.WriteLine("Cutting pizza.");
		}

		public void Box()
		{
			Console.WriteLine("Putting the pizza in a box.");
		}
	}
}
