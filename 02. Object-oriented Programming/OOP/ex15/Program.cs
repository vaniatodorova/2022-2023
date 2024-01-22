using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex15
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] names = Console.ReadLine().Split(' ').ToArray();
			Func<string, int> print = name => Console.WriteLine(name);
			foreach (string name in names)
			{
				print("Sir " + name);
			}
		}
	}
}
