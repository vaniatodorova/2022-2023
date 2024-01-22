using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ex07___06._02._23
{
	class FirstThread
	{
		public void DoTask1() //thread1 instruction
		{
			for (int i = 0; i < 100; i++)
			{
			Console.WriteLine("Thread1:job({0})", i); //prints numbers 1-100 Thread1:job(34)
			Thread.Sleep(1); //stops the thread for 1 milisec
		    }
		}
		public void DoTask2() //thread2 instruction
		{
			for (int i = 0; i < 100; i++)
			{
			Console.WriteLine("Thread2:job({0})", i);  //same as thread1 but this is thread2
			Thread.Sleep(1); //stops the thread for 1 milisec
		    }
		}
	}
	class Starter
	{
		static void Main(string[] args)
		{
			FirstThread ft = new FirstThread();
			Thread t1 = new Thread(new ThreadStart(ft.DoTask1)); //connects t1 to DoTask1()
			Thread t2 = new Thread(new ThreadStart(ft.DoTask2)); //connects t2 to DoTask2()
			t1.Start(); //starts thread1
			t2.Start(); //starts thread2
		}
	}
}
