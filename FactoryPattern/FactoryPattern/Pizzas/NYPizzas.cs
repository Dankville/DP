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
	class NYCheesePizza : Pizza
	{
		public NYCheesePizza() : base()
		{
			Name = "NY Style Sauce and cheese pizza";
			Dough = "This crust dough";
			Sauce = "Marinara sauce";

			Toppings.Add("Grated Reggiana Cheese");
		}
	}

	class NYClamPizza : Pizza
	{

	}

	class NYPepperoniPizza : Pizza
	{

	}

	class NYVeggiePizza : Pizza
	{

	}
}
