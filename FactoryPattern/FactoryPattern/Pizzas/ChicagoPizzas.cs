using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern.Pizzas
{
	/// <summary>
	/// Abstract Product Class
	/// </summary>
	class ChicagoCheesePizza : Pizza
	{
		public ChicagoCheesePizza()
		{
			Name = "Chicago Style deep dish cheese pizza";
			Dough = "Extra thick crust dough";
			Sauce = "Plum Tomato Sauce";

			Toppings.Add("Shredded Mozzaralle cheese");
		}

		public override void Cut()
		{
			Console.WriteLine("Cutting the pizza in square slices.");
		}
	}

	class ChicagoClamPizza : Pizza
	{

	}

	class ChicagoPepperoniPizza : Pizza
	{

	}

	class ChicagoVeggiePizza : Pizza
	{

	}
}
