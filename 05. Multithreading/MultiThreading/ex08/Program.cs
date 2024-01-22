using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Collections.Concurrent;

namespace ex08
{
	class Program
	{
		static int counter = 0;
		static List<int> sharedList = new List<int>();
		static ConcurrentDictionary<int, int> concurrentDictionary = new ConcurrentDictionary<int, int>();
		static void Main(string[] args)
		{
			Console.WriteLine("-----ex01-----");
			Thread thread1 = new Thread(IncrementCounter);
			Thread thread2 = new Thread(IncrementCounter);
			thread1.Start();
			thread2.Start();

			thread1.Join();
			thread2.Join();
			Console.WriteLine("Final Counter Value: " + counter);
			Console.WriteLine("-----ex02-----");
			Thread thread3 = new Thread(AddToList);
			Thread thread4 = new Thread(AddToList);

			thread3.Start(1);
			thread4.Start(2);

			thread3.Join();
			thread4.Join();
			Console.WriteLine("Final List: ");
			foreach (var item in sharedList)
			{
				Console.WriteLine(item);
			}
			Console.WriteLine("-----ex03-----");
			Thread thread5 = new Thread(() => AddToDictionary(1, 100));
			Thread thread6 = new Thread(() => AddToDictionary(1, 200));
			thread5.Start();
			thread6.Start();

			thread5.Join();
			thread6.Join();
			Console.WriteLine("Final Dictionary: ");
			foreach(var item in concurrentDictionary)
			{
				Console.WriteLine("Key: " + item.Key + " Value " + item.Value);
			}

		}
		private static void IncrementCounter()
		{
			for (int i = 0; i < 100000; i++)
			{
				counter++;
			}
		}
		private static void AddToList(object item)
		{
			lock (sharedList)
			{
				sharedList.Add((int)item);
			}
		}
		private static void AddToDictionary(int key, int value)
		{
			concurrentDictionary[key] = value;
		}
	}
}
