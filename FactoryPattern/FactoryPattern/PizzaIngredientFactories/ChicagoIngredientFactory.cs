using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern.Ingredients;

namespace FactoryPattern.PizzaIngredientFactories
{
	class ChicagoIngredientFactory : PizzaIngredientFactory
	{
		public Cheese CreateCheese()
		{
			throw new NotImplementedException();
		}

		public Clams CreateClams()
		{
			throw new NotImplementedException();
		}

		public Dough CreateDough()
		{
			throw new NotImplementedException();
		}

		public Pepperoni CreatePepperoni()
		{
			throw new NotImplementedException();
		}

		public Sauce CreateSauce()
		{
			throw new NotImplementedException();
		}

		public Veggies[] CreateVeggies()
		{
			throw new NotImplementedException();
		}
	}
}
