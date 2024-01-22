using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex01
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("first number: ");
			int a = int.Parse(Console.ReadLine());
			Console.Write("second number: ");
			int b = int.Parse(Console.ReadLine());
			Console.Write("third number: ");
			int c = int.Parse(Console.ReadLine());
			int S = a + b + c;
			Console.Write("{0} + {1} + {2} = {3}", a, b, c, S);
		}
	}
}
