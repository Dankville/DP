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
			PizzaStore chic = new ChicagoPizzaStore();

			Pizza order = ny.OrderPizza("Cheese");
			Console.WriteLine($"Ethan ordered a {order.Name} \n");

			order = chic.OrderPizza("Cheese");
			Console.WriteLine($"Joel ordered a {order.Name}");

			Console.ReadKey();
		}
	}
}
