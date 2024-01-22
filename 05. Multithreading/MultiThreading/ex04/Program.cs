using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ex04___06._02._23
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Main thread starts here.");
			Program.DoSomeHeavyLifting();
			Program.DoSomething();
			Console.WriteLine("Main thread ends here.");
		}
		public static void DoSomeHeavyLifting()
		{
			Console.WriteLine("I'm lifting a truck!!");
			Thread.Sleep(1000);
			Console.WriteLine("Tired! need a 3 sec nap.");
			Thread.Sleep(1000);
			Console.WriteLine("1....");
			Thread.Sleep(1000);
			Console.WriteLine("2....");
			Thread.Sleep(1000);
			Console.WriteLine("3....");
			Console.WriteLine("I'm awake.");

		}
		public static void DoSomething()
		{
			Console.WriteLine("Hey! DoSomething here!");
			for (int i = 0; i < 20; i++)
				Console.Write($"{i} ");
			Console.WriteLine();
			Console.WriteLine("I'm done.");
		}
	}
}
