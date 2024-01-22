using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Threading.Tasks;

namespace ex12___06._02._23
{
	class MyClass
	{
		private int privateField = 42;
		private void PrivateMethod()
		{
			Console.WriteLine("Private Method Invoked");
		}
	}
	class Program
	{
		static void Main(string[] args)
		{
			Type type = typeof(MyClass);
			FieldInfo field = type.GetField("privateField", BindingFlags.NonPublic | BindingFlags.Instance);
			MyClass obj = new MyClass();
			int value = (int)field.GetValue(obj);
			Console.WriteLine("Private Field Value: " + value);
			MethodInfo method = type.GetMethod("PrivateMethod", BindingFlags.NonPublic | BindingFlags.Instance);
			method.Invoke(obj, null);
		}
	}
}
