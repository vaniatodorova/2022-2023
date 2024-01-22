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
			Console.Write("first: ");
			int a = int.Parse(Console.ReadLine());
			Console.Write("second: ");
			int b = int.Parse(Console.ReadLine());
			int n;
			int m;
			if (a > b)
			{
				n = a;
				m = b;
			b = n;
				a = m;
				Console.Write("{0} > {1} -> first = {1} & second = {0} ", n, m);
			}
			else { Console.Write("{0} > {1} ", b, a);
			}
		}
	}
}
