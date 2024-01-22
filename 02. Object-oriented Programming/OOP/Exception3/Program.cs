using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception3
{
	class Program
	{
		static void Main()
		{
			List<int> numbers = new List<int>() { 1, 2, 3, 4, 5 };
			int index = 10;
			try
			{
				Console.WriteLine("Number at index {0}: {1}", index, numbers[index]);
			}
			catch (ArgumentOutOfRangeException ex)
			{
				Console.WriteLine("Error: Index out of range.");
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error: " + ex.Message);
			}
		}
	}
}
