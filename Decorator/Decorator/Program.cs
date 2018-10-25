using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Decorator.Beverages;
using Decorator.CondimentDecorators;

namespace Decorator
{
	class Program
	{
		static void Main(string[] args)
		{
			Beverage bev1 = new Espresso();
			Print(bev1);

			Beverage bev2 = new DarkRoast();
			bev2 = new Mocha(bev2);
			bev2 = new Mocha(bev2);
			bev2 = new Whip(bev2);
			Print(bev2);

			Beverage bev3 = new HouseBlend();
			bev3 = new Soy(bev3);
			bev3 = new Mocha(bev3);
			bev3 = new Whip(bev3);
			Print(bev3);

			Console.ReadKey();
		}

		static void Print(Beverage bev)
		{
			Console.WriteLine($"{bev.GetDescription()} ${bev.Cost()}"); 
		}
	}
}
