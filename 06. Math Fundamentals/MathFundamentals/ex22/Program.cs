using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex22
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] array = { 1, 2, 3, 2, 4, 5, 3 };
			HashSet<int> set = new HashSet<int>();
			for(int i = 0; i < array.Length; i++)
			{
				set.Add(array[i]);
			}
			int[] newArray = new int[set.Count];
			set.CopyTo(newArray);
			Console.WriteLine("Masivut bez dublirashti se elementi e:");
			for(int i = 0; i < newArray.Length; i++)
			{
				Console.WriteLine("{0}", newArray[i]);
			}
			Console.WriteLine();
		}
	}
}
