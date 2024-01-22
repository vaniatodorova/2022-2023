using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex18
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			Func<string, int> parser = n => int.Parse(n);
			int[] numbers = input.Split(new string[] { ", " },
				StringSplitOptions.RemoveEmptyEntries).Select(parser).ToArray();
			Console.WriteLine(numbers.Length);
			Console.WriteLine(numbers.Sum());
		}
	}
}
