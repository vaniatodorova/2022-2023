using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ex11
{
	class Program
	{
		static object lock1 = new object();
		static object lock2 = new object();
		static void Main(string[] args)
		{
			Thread thread1 = new Thread(() =>
			{
				lock (lock1)
				{
					Console.WriteLine("Thread 1: locked lock1");
					Thread.Sleep(1000);
					lock (lock2)
					{
						Console.WriteLine("Thread 1: locked lock2");
					}
				}
			});
			Thread thread2 = new Thread(() =>
			{
				lock (lock2)
				{
					Console.WriteLine("Thread 2: locked lock2");
					Thread.Sleep(1000);
					lock (lock1)
					{
						Console.WriteLine("Thread 2: locked lock1");
					}
				}
			});
			thread1.Start();
			thread2.Start();
			Thread.Sleep(2000);
			lock (lock1)
			{
				Console.WriteLine("Main Thread: locked lock1");
				lock (lock2)
				{
					Console.WriteLine("Main Thread: locked lock2");
				}
			}
		}
	}
}
