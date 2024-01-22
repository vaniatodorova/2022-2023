using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ex01___06._02._23
{
	class Program
	{
		static void Main(string[] args)
		{
			Thread t1 = new Thread(new ThreadStart(MyThread.Thread1));
			Thread t2 = new Thread(new ThreadStart(MyThread.Thread1));
			t1.Start();
			t2.Start();
		}
	}
}
