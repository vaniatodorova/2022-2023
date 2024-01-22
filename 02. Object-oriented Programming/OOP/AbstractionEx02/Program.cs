using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionEx02
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			for(int i = 0; i < n; i++)
			{
				string[] data = Console.ReadLine().Split(' ').ToArray();
				ColoredFigure figure;
				switch (data[0])
				{
					case "Triangle":
						{
							double size = double.Parse(data[2]);
							figure = new Triangle(data[1], size);
							figure.Show();
							break;
						}
					case "Circle":
						{
							double size = double.Parse(data[2]);
							figure = new Circle(data[1], size);
							figure.Show();
							break;
						}
					case "Square":
						{
							double size = double.Parse(data[2]);
							figure = new Square(data[1], size);
							figure.Show();
							break;
						}
				}
			}
		}
	}
}
