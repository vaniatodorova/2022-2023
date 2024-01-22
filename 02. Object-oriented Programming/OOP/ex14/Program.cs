using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex14
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] names = Console.ReadLine().Split(' ').ToArray();
			Action<string> print = name => Console.WriteLine(name);
			foreach (string name in names)
			{
				print(name);
			}
		}
	}
}
