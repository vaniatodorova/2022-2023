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
			Console.Write("A: ");
			int a = int.Parse(Console.ReadLine());
			Console.Write("B: ");
			int b = int.Parse(Console.ReadLine());
			Console.Write("H: ");
			int h = int.Parse(Console.ReadLine());
			int S = (a + b) / (2 * h);
			Console.Write("S = " + S);
		}
	}
}
