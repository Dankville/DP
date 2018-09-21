using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern.Pizzas;

namespace FactoryPattern.PizzaStores
{
	class NYPizzaStore : PizzaStore
	{
		public NYPizzaStore() : base()
		{
		}

		public override Pizza CreatePizza(string type)
		{
			Pizza pizza = null;

			switch (type.ToLower())
			{
				case "cheese":
					pizza = new NYCheesePizza();
					break;
				case "pepperoni":
					pizza = new NYPepperoniPizza();
					break;
				case "clam":
					pizza = new NYClamPizza();
					break;
				case "veggie":
					pizza = new NYVeggiePizza();
					break;
				default:
					break;
			}

			return pizza;
		}
	}
}
