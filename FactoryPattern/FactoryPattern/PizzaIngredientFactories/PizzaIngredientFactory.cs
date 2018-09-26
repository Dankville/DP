using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern.Ingredients;

namespace FactoryPattern
{
	interface PizzaIngredientFactory
	{
		Dough CreateDough();
		Sauce CreateSauce();
		Cheese CreateCheese();
		Veggies[] CreateVeggies();
		Pepperoni CreatePepperoni();
		Clams CreateClams();
	}
}
