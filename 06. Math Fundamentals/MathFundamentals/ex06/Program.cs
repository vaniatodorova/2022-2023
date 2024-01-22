using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex06
{
	class Program
	{
		static void Main(string[] args)
		{
			double x, y;
			Console.WriteLine("		X		Y");
			Console.WriteLine("---------------");
			for (x = -2; x <= 4; x += 0.5)
			{
				y = x * x - 3 * x + 2;
				Console.WriteLine("{0,5:F1} {1,7:F2}", x, y);
			}
		}
	}
}
