using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
	class Circle : Shape
	{
		private string _Color;
		public int X { get; set; }
		public int Y { get; set; }
		public int Radius { get; set; }

		private Circle(string color)
		{
			this._Color = color;
		}

		public void Draw()
		{
			Console.WriteLine($"Circle: Draw() [Color: {_Color}, X: {X}, Y: {Y}]");
		}
	}
}
