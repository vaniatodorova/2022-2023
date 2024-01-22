using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ex06___06._02._23
{
	class Program
	{
		static void Main()
		{
			Thread workerThread = new Thread(new ThreadStart(Print));
			workerThread.Start();
			for(int i = 0; i < 10; i++)
			{
				Console.WriteLine($"Main thread: {i}");
				Thread.Sleep(200);
			}
		}
		static void Print()
		{
			for(int i = 11; i < 20; i++)
			{
				Console.WriteLine($"Worker thread:{i}");
				Thread.Sleep(1000);
			}
		}
	}
}
