using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex16
{
	class Program
	{
		static void Main(string[] args)
		{
			List<int> nums = Console.ReadLine().Split().Select(int.Parse).ToList();
			var minNum = nums.Min(x=>x);
			Console.WriteLine(minNum);
		}
	}
}
