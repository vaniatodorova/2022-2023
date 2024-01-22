using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex09
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] Nums = new string[10] { "нула", "едно", "две", "три", "четири", "пет", "шест", "седем", "осем", "девет" };
			Console.WriteLine("число от 0-9: ");
			int a = int.Parse(Console.ReadLine());
			Console.WriteLine(Nums[a]);
		}
	}
}
