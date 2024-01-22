using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Threading.Tasks;

namespace ex11___06._02._23
{
	class Program
	{
		static void Main(string[] args)
		{
			Type type = typeof(Math);
			MethodInfo method = type.GetMethod("Max", new Type[] { typeof(int), typeof(int) });
			int result = (int)method.Invoke(null, new object[] { 10, 20 });
			Console.WriteLine("Max Value: " + result);
		}
	}
}
