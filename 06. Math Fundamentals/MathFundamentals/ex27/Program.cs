using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.Distributions;

namespace ex27
{
	class Program
	{
		static void Main(string[] args)
		{
			int N = 5;
			double p = 0.3;
			int X = 2;

			double probability = Binomial.PMF(p, N, X);
			Console.WriteLine("Probability: " + probability);
		}
	}
}
