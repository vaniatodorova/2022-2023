using System;
using System.Threading;

namespace ex14
{
	class Program
	{
		static Mutex mutex = new Mutex();

		static void Main(string[] args)
		{
			for (int i = 0; i < 5; i++)
			{
				Thread thread = new Thread(DoWork);
				thread.Start();
			}
			Console.ReadLine();
		}
		static void DoWork()
		{
			mutex.WaitOne();
			Console.WriteLine("Nishka {0} vleze v kritichna sekciq.", Thread.CurrentThread.ManagedThreadId);
			Thread.Sleep(1000);
			Console.WriteLine("Nishka {0} vleze v kritichna sekciq.", Thread.CurrentThread.ManagedThreadId);
			mutex.ReleaseMutex();
		}
	}
}
