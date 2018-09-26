using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
	class Program
	{
		static void Main(string[] args)
		{
			MallardDuck duck = new MallardDuck();

			WildTurkey turkey = new WildTurkey();
			TurkeyAdapter TurkeyAdapter = new TurkeyAdapter(turkey);


			Console.WriteLine();

			Console.WriteLine("The turkey says....");
			turkey.Gobble();
			turkey.Fly();


			Console.WriteLine();

			Console.WriteLine("The duck says....");
			TestDuck(duck);

			Console.WriteLine();

			Console.WriteLine("The turkey says....");
			TestDuck(TurkeyAdapter);

			Console.ReadKey();
		}

		static void TestDuck(Duck duck)
		{
			duck.Quack();
			duck.Fly();
		}
	}
}
