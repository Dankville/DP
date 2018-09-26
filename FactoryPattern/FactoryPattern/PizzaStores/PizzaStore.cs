using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern.Pizzas;

namespace FactoryPattern.PizzaStores
{
	/// <summary>
	/// Abstract creator class
	/// </summary>
	public abstract class PizzaStore
	{

		public Pizza OrderPizza(string type)
		{
			Pizza pizza = CreatePizza(type);

			if (pizza == null)
				throw new Exception("Unknown pizza ordered.");

			pizza.Prepare();
			pizza.Bake();
			pizza.Cut();
			pizza.Box();
			return pizza;
		}


		/// <summary>
		/// High level Abstract pizza Facory Method
		/// </summary>
		/// <param name="type">Type of pizza</param>
		/// <returns> Abstract pizza </returns>
		public abstract Pizza CreatePizza(string type);
	}
}
