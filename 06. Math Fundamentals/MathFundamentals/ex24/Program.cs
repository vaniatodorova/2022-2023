using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex24
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			double p = double.Parse(Console.ReadLine());
			double q = 1 - p;
			double probability = 1 - Math.Pow(q, n);
			Console.WriteLine("Probability of at least one success: " + probability);
		}
	}
}
