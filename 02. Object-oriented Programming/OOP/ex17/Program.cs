using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex17
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
			string filter = Console.ReadLine();
			List<int> actualNums = new List<int> { };
			int min = nums[0];
			int max = nums[1];
			int i = min;
 
		 
			while (i <= max)
			{
				actualNums.Add(i); 
				i++;
			}
			 
			if ("even".Equals(filter))
			{
				Predicate<int> even = delegate (int val) { return val % 2 == 0; };
				var filtered = actualNums.FindAll(even);

				Console.WriteLine(string.Join(",", filtered));
			}
			else if("odd".Equals(filter))
			{
				Predicate<int> odd = delegate (int val) { return val % 2 != 0; };
				var filtered = actualNums.FindAll(odd);

				Console.WriteLine(string.Join(" ", filtered));
			}
		}
	}
}
