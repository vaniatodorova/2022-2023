using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex05
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("write a number: ");
			int a = int.Parse(Console.ReadLine());
			if (a % 2 == 0)
			{
				Console.WriteLine("числото е четно ");
			}
			else
			{
				Console.WriteLine("числото не е четно ");
			}
		}
	}
}
