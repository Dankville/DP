using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern.Ingredients;


namespace FactoryPattern.Pizzas
{
	/// <summary>
	/// Abstract Product Class
	/// </summary>
	public abstract class Pizza
	{
		public string Name { get; protected set; }

		public Dough Dough { get; protected set; }
		public Sauce Sauce { get; protected set; }
		public Veggies[] Veggies { get; protected set; }
		public Cheese Cheese { get; protected set; }
		public Pepperoni Pepperoni { get; protected set; }
		public Clams Clams { get; protected set; }


		/// <summary>
		/// High-level Abstract PizzaFactoryIngredient Factory Method
		/// </summary>
		public abstract void Prepare();

		public void Bake()
		{
			Console.WriteLine("Baking pizza");
		}

		public virtual void Cut()
		{
			Console.WriteLine("Cutting pizza.");
		}

		public void Box()
		{
			Console.WriteLine("Putting the pizza in a box.");
		}
	}
}
