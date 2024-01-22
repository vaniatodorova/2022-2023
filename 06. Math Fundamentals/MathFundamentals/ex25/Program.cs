using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex25
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			int k = int.Parse(Console.ReadLine());
			double p = double.Parse(Console.ReadLine());
			double q = 1 - p;
			double probability = Combination(k, n) * Math.Pow(p, k) * Math.Pow(q, n - k);
			Console.WriteLine("Conditional probability of k successes: " + probability);
		}
		static int Factorial(int n)
		{
			if (n <= 1)
			{
				return 1;
			}
			return n * Factorial(n - 1);
		}
		static int Combination(int n, int k)
		{
			return Factorial(n) / (Factorial(n - k));
		}
	}
}
