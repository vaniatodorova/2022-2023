using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex11
{
	class Program
	{
		static void Main(string[] args)
		{
			double x, y;
			Console.WriteLine("		X		Y");
			Console.WriteLine("---------------");
			for (x = -5; x <= 5; x += 0.1)
			{
				y = Math.Pow(x, 3) - 3 * Math.Pow(x, 2) + 3 * x - 1;
				Console.WriteLine("{0,5:F1} {1,7:F2}", x, y);
			}
		}
	}
}
