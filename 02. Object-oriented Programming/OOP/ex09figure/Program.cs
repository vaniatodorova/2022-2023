using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex09figure
{
	class Program
	{
		static void Main(string[] args)
		{
			var radius = int.Parse(Console.ReadLine());
			IDrawable circle = new Circle(radius);
            var width = int.Parse(Console.ReadLine());
			var heigth = int.Parse(Console.ReadLine());
			IDrawable rect = new Rectangle(width, heigth);
			circle.Draw();
			rect.Draw();
		}
	}
}
