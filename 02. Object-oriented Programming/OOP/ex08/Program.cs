using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex08
{
	class Program
	{
		static void Main(string[] args)
		{
			RandomList randomList = new RandomList();
			randomList.RandomString();
			foreach (var n in randomList)
			{
				Console.WriteLine(n);
			}
		}
	}
}
