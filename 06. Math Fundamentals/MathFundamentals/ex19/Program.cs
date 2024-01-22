using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex19
{
	class Program
	{
		static void Main(string[] args)
		{
			HashSet<int> set1 = new HashSet<int> { 1, 2, 3 };
			HashSet<int> set2 = new HashSet<int> { 4, 5, 6 };
			HashSet<int> unionSet = new HashSet<int>(set1);
			unionSet.UnionWith(set2);
			Console.WriteLine("Slivaneto na dvete mnojestva e: ");
			foreach(int i in unionSet)
			{
				Console.WriteLine(i);
			}
		}
	}
}
