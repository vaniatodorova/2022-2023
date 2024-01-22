using System;
using System.Threading;

namespace ex18
{
	class Program
	{
		static void Main()
		{
			Console.WriteLine("Startirane na asinhronna operaciq...");
			ThreadPool.QueueUserWorkItem(DoWork);
			Console.WriteLine("Izpulvane na drugata rabota v osnovnata nishka...");
			Console.WriteLine("Izchakvane na zavurshvaneto na operaciqta...");
			Thread.Sleep(2000);
			Console.WriteLine("Operaciqta prikliuchi.");
			Console.ReadLine();
		}
		static void DoWork(object state)
		{
			Console.WriteLine("Asinhonnata operaciq startira...");
			Thread.Sleep(3000);
			Console.WriteLine("Asinhronnata operaciq prikliuchi.");
		}
	}
}
