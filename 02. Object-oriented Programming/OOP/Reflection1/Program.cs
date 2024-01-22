using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection1
{
	class Program
	{
		static void Main(string[] args)
		{
			Spy spy=new Spy();
			string result = spy.StealFieldInfo("Hacker", "username", "password");
			Console.WriteLine(result);
		}
	}
}
