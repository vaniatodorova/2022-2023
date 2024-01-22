using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex07
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("A=");
			double a = double.Parse(Console.ReadLine());
			Console.Write("B=");
			double b = double.Parse(Console.ReadLine());
			Console.Write("C=");
			double c = double.Parse(Console.ReadLine());
			double x, y;
			Console.WriteLine("		X		Y");
			Console.WriteLine("---------------");
			for (x = -10; x <= 10; x += 0.5)
			{
				y = a* x * x + b * x + c;
				Console.WriteLine("{0,5:F1} {1,7:F2}", x, y);
			}
		}
	}
}
