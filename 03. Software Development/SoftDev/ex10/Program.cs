using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex10
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int a = 1;
			do
			{
				if (a % (7 * 3) != 0)
				{
					Console.Write("{0} ", a);
				}
				a++;
			} while (a <= n);
		}
	}
}
