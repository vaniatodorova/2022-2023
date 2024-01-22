using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception1
{
	class Program
	{
		static void Main()
		{
			int num1, num2, result;
			Console.Write("Enter first number: ");
			num1 = int.Parse(Console.ReadLine());
			Console.Write("Enter second number: ");
			num2 = int.Parse(Console.ReadLine());
			try
			{
				result = num1 / num2;
				Console.WriteLine("Result: " + result);
			}
			catch (DivideByZeroException ex)
			{
				Console.WriteLine("Error: " + ex.Message);
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error: " + ex.Message);
			}
		}
	}
}
