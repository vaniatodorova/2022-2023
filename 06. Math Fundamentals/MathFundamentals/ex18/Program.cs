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
			HashSet<int> set1 = new HashSet<int> { 1, 2, 3 };
			HashSet<int> set2 = new HashSet<int> { 1, 2, 3, 4, 5 };
			if (set1.IsSubsetOf(set2))
			{
				Console.WriteLine("set1 e podmnojestvo na set2");
			}
			else
			{
				Console.WriteLine("set1 ne e podmnojestvo na set2");
			}
		}
	}
}
