using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommunicationArguments
{
	class Program
	{
		static void Main(string[] args)
		{
			MyClass obj = new MyClass();
			obj.OnEvent += new EventHandler(obj_OnEvent);
			obj.DoSomething();
		}

		static void obj_OnEvent(object sender, EventArgs e)
		{
			Console.WriteLine("Event occured!");
		}
	}
}
