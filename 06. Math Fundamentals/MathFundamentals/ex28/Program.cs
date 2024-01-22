using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathNet.Numerics.Distributions;

namespace ex28
{
	class Program
	{
		static void Main(string[] args)
		{
			double mean = 0.0;
			double stddev = 1.0;
			double x = 1.5;
			double probability = 1 - Normal.CDF(mean, stddev, x);
			Console.WriteLine("Probability: " + probability);
		}
	}
}
