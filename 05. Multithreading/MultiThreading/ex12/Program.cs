using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ex12
{
	class Program
	{
		static object lock1 = new object();
		static object lock2 = new object();
		static object lock3 = new object();
		static object lock4 = new object();
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
						Thread.Sleep(1000);
						lock (lock3)
						{
							Console.WriteLine("Thread 1: locked lock3");
							Thread.Sleep(1000);
							lock (lock4)
							{
								Console.WriteLine("Thread 1: locked lock4");
							}
						}
					}
				}
			});
		}
	}
}
