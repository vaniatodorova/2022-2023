using System;
using System.Threading.Tasks;

namespace ex17
{
	class Program
	{
		static void Main()
		{
			Task<int> task = Task.Run(() => CalculateSum(10));
			Console.WriteLine("Izchakvane na rezultta...");
			int result = task.GetAwaiter().GetResult();
			Console.WriteLine("Rezultatut e: " + result);
			Console.ReadLine();
		}
		static int CalculateSum(int n)
		{
			int sum = 0;
			for(int i = 1; i <= n; i++)
			{
				sum += i;
			}
			return sum;
		}
	}
}
