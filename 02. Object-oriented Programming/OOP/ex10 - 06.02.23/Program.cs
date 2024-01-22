using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ex10___06._02._23
{
	class Program
	{
		static void Main(string[] args)
		{
			Type type = typeof(System.String);
		    Console.WriteLine("Full Name: " + type.FullName);
		    Console.WriteLine("Namespace: " + type.Namespace);
		    Console.WriteLine("Base Type: " + type.BaseType);
	    }
    }
}
