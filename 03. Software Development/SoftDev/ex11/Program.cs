using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex11
{
	class Program
	{
		static void Main(string[] args)
		{
			double sum;
			Console.Write("Kilometers: ");
			double km = double.Parse(Console.ReadLine());
			Console.Write("Day or Night: ");
			string time = Console.ReadLine();
			if (km < 20)
			{
				if(time == "day")
				{
					sum = 0.70 + km * 0.79;
					Console.WriteLine("Traverling with Taxi through out the day for {0}",sum);
				}
				else if (time == "night")
				{
					sum = 0.70 + km * 0.90;
					Console.WriteLine("Traverling with Taxi through out the night for {0}", sum);
				}
			}
			else if (20 >= km || km < 100)
			{
				sum = km * 0.09;
			    Console.WriteLine("Traverling with Bus through out the day for {0}", sum);
			}
			else if (km >= 100)
			{
				sum = km * 0.06;
				Console.WriteLine("Traverling with Train through out the day for {0}", sum);
			}
		}
	}
}
