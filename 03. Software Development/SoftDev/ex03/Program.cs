using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex03
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("from: ");
			int a = int.Parse(Console.ReadLine());
			Console.Write("to: ");
			int b = int.Parse(Console.ReadLine());
			int n = 0;
			do
			{
				if (a % 5 == 0)
				{
					Console.Write(a + " ");
					n++;
				}
				a++;
			} while (a <= b);
            Console.WriteLine();
			Console.Write("числа завършващи на 5 и 0(брой): {0} ", n);
		}
	}
}
