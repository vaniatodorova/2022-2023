using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex20
{
	class Program
	{
		static void Main(string[] args)
		{
			HashSet<int> set = new HashSet<int>();
			set.Add(1);
			set.Add(2);
			set.Add(3);
			set.Add(1);
			Console.WriteLine("Broqt na unikalnite elementi v mnojestvoto e: {0}", set.Count);
		}
	}
}
