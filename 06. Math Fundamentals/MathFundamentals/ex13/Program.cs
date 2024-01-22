using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex13
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] numbers = { 5, 2, 8, 1, 9, 4 };
			Console.WriteLine("Before sorting: ");
			foreach(var number in numbers)
			{
				Console.WriteLine(number + " ");
			}
			Array.Sort(numbers, CompareNumbers);
			Console.WriteLine("After sorting: ");
			foreach (var number in numbers)
			{
				Console.WriteLine(number + " ");
			}
		}
		static int CompareNumbers(int x, int y)
		{
			if (x < y)
			{
				return - 1;
			}
			else if (x > y)
			{
				return 1;
			}
			else
			{
				return 0;
			}
		}
	}
}
