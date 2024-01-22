using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunicationArguments2
{
	class Program
	{
		public delegate void MyDelegate();
		public event MyDelegate MyEvent;
		static void Main(string[] args)
		{
			Program obj = new Program();
			obj.MyEvent += new MyDelegate(obj_MyEvent);
			obj.DoSomething();
		}
		static void obj_MyEvent()
		{
			Console.WriteLine("Event occurred!");
		}
		public void DoSomething()
		{
			if (MyEvent != null)
			{
				MyEvent();
			}
		}
	}
}
