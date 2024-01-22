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
			Console.Write("first number: ");
			int a = int.Parse(Console.ReadLine());
			Console.Write("second number: ");
			int b = int.Parse(Console.ReadLine()); Console.Write("third number: ");
			int c = int.Parse(Console.ReadLine());
			int n = Math.Max(a, b);
			int m = Math.Max(n, c);
			Console.WriteLine();
			Console.Write("biggest number: {0} ", m);
		}
	}
}
