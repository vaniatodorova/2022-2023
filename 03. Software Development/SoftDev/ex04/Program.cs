using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex04
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("first number: ");
			int a = int.Parse(Console.ReadLine());
			Console.Write("second number: ");
			int b = int.Parse(Console.ReadLine());
			int n = Math.Max(a, b);
			int m = Math.Min(a, b);
			Console.WriteLine("{0} > {1} ", n, m);
		}
	}
}
