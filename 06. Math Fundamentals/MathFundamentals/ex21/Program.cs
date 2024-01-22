using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex21
{
	class Program
	{
		static void Main(string[] args)
		{
			HashSet<int> set = new HashSet<int> { 1, 2, 3 };
			Console.WriteLine("Vsichki podmnojestva na mnojestvoto sa: ");
			foreach(var subset in GetSubsets(set))
			{
				Console.Write("{");
				foreach(var item in subset)
				{
					Console.Write("{0} ", item);
				}
				Console.WriteLine("}");
			}
		}
		static IEnumerable<IEnumerable<T>> GetSubsets<T>(HashSet<T> set)
		{
			int n = set.Count;
			T[] array = new T[n];
			set.CopyTo(array);
			for (int i = 0; i < (1 << n); i++)
			{
				yield return Subset(array, i);
			}
		}
		static IEnumerable<T> Subset<T>(T[] array, int bits)
		{
			for (int i = 0; i < array.Length; i++)
			{
				if ((bits & (1 << i)) != 0)
				{
					yield return array[i];
				}
			}
		}
	}
}
