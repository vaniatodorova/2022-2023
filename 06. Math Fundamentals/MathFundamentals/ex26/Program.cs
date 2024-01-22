using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex26
{
	class Program
	{
		static void Main(string[] args)
		{
			int N = 10;
			double p = 0.5;
			int M = 5;
			int K = 3;
			int totalSimulations = 10000;
			int successCount = 0;
			Random random = new Random();
			for(int i = 0; i < totalSimulations; i++)
			{
				int success = 0;
				for(int j = 0; j < M; j++)
				{
					if (random.NextDouble() < p)
					{
						success++;
					}
				}
				if (success >= K)
				{
					successCount++;
				}
			}
			double probability = (double)successCount / totalSimulations;
			Console.WriteLine("Probability: "+probability);
		}
	}
}
