using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex12
{
	class Program
	{
		static void Main(string[] args)
		{
			double x, y;
			Console.WriteLine("		X		Y");
			Console.WriteLine("---------------");
			for (x = 0; x <= 10; x += 0.1)
			{
				y = Math.Sqrt(x) * Math.Sin(x);
				Console.WriteLine("{0,5:F1} {1,7:F2}", x, y);
			}
		}
	}
}
