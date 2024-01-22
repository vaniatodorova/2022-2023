using System;
using System.Collections.Concurrent;
using System.Threading;

namespace ex16
{
	class Program
	{
		static BlockingCollection<int> queue = new BlockingCollection<int>(3);

		static void Main()
		{
			Thread producerThread = new Thread(Producer);
			Thread consumerThread = new Thread(Consumer);
			producerThread.Start();
			consumerThread.Start();
			Console.ReadLine();
			queue.CompleteAdding();
		}
		static void Producer()
		{
			for(int i = 0; i < 5; i++)
			{
				queue.Add(i);
				Console.WriteLine("Proizvolen element: " + i);
				Thread.Sleep(500);
			}
		}
		static void Consumer()
		{
			foreach (var item in queue.GetConsumingEnumerable())
			{
				Console.WriteLine("Konsumiran element: "+item);
				Thread.Sleep(1000);
			}
		}
	}
}
