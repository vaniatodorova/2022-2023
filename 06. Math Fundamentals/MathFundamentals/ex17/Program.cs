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
			HashSet<int> set1 = new HashSet<int> { 1, 2, 3, 4, 5 };
			HashSet<int> set2 = new HashSet<int> { 4, 5, 6, 7, 8 };
			HashSet<int> intersectionSet = new HashSet<int>(set1);
			intersectionSet.IntersectWith(set2);
			Console.WriteLine("Obshtite elementi v dvata mnojestva sa: ");
			foreach(int i in intersectionSet)
			{
				Console.WriteLine(i);
			}
		}
	}
}
