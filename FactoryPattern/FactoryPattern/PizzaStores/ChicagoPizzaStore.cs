using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern.Pizzas;

namespace FactoryPattern.PizzaStores
{
	class ChicagoPizzaStore : PizzaStore
	{
		public ChicagoPizzaStore() : base()
		{
		}

		public override Pizza CreatePizza(string type)
		{
			Pizza pizza = null;

			switch (type.ToLower())
			{
				case "cheese":
					pizza = new ChicagoCheesePizza();
					break;
				case "pepperoni":
					pizza = new ChicagoPepperoniPizza();
					break;
				case "clam":
					pizza = new ChicagoClamPizza();
					break;
				case "veggie":
					pizza = new ChicagoVeggiePizza();
					break;
				default:
					break;
			}

			return pizza;
		}
	}
}
