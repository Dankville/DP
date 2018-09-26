using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern.Pizzas;

namespace FactoryPattern.PizzaStores
{
	/// <summary>
	/// Concerete creator class
	/// </summary>
	class CaliforniaPizzaStore : PizzaStore
	{
		public override Pizza CreatePizza(string type)
		{
			Pizza pizza = null;

			/// <summary>
			/// Low level concrete pizza factory method.
			/// </summary>
			/// <param name="type">Type of pizza</param>
			/// <returns>Concrete California Style pizza</returns>
			switch (type.ToLower())
			{
				case "cheese":
					pizza = new CaliforniaCheesePizza();
					break;
				case "pepperoni":
					pizza = new CaliforniaPepperoniPizza();
					break;
				case "clam":
					pizza = new CaliforniaClamPizza();
					break;
				case "veggie":
					pizza = new CaliforniaVeggiePizza();
					break;
				default:
					break;
			}

			return pizza;
		}
	}
}
