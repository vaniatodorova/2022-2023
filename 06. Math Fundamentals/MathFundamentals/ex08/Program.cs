using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex08
{
	class Program
	{
		static void Main(string[] args)
		{
			double x, y;
			Console.WriteLine("		X		Y");
			Console.WriteLine("---------------");
			for (x = -Math.PI; x <= Math.PI; x += 0.1)
			{
				y = Math.Sin(x);
				Console.WriteLine("{0,5:F1} {1,7:F2}", x, y);
			}
		}
	}
}
