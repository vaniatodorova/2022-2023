using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex23
{
	class Program
	{
		static void Main(string[] args)
		{
			Random rand = new Random();
			int count = 0;
			for(int i = 0; i < 100; i++)
			{
				double num = rand.NextDouble();
				if (num > 0.5)
				{
					count++;
				}
			}
			Console.WriteLine("Number of values greater than 0.5: " + count);
		}
	}
}
