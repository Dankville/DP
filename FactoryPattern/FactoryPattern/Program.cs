using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern.Pizzas;
using FactoryPattern.PizzaStores;

namespace FactoryPattern
{
	class Program
	{
		static void Main(string[] args)
		{
			PizzaStore ny = new NYPizzaStore();

			Pizza order = ny.OrderPizza("Cheese");

			Console.WriteLine(order.GetType());

			Console.ReadKey();
		}
	}
}
