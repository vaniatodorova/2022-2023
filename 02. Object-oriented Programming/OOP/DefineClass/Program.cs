using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefineClass
{
	class Program
	{
		static void Main(string[] args)
		{
			Person pesho = new Person("Pesho", "Peshev", 24);
			try
			{
				Person noName = new Person(string.Empty, "Goshev", 31);
			}
			catch(ArgumentNullException ex)
			{
				Console.WriteLine("Exception thrown: {0}", ex.Message);
			}
			catch(ArgumentOutOfRangeException ex)
			{
				Console.WriteLine("Exception thrown: {0}", ex.Message);
			}
			try
			{
				Person NoLastName = new Person("Ivan", null, 63);
			}
			catch (ArgumentNullException ex)
			{
				Console.WriteLine("Exception thrown: {0}", ex.Message);
			}
			catch (ArgumentOutOfRangeException ex)
			{
				Console.WriteLine("Exception thrown: {0}", ex.Message);
			}
			try
			{
				Person negativeAge = new Person("Stoyan", "Kolev", -1);
			}
			catch (ArgumentNullException ex)
			{
				Console.WriteLine("Exception thrown: {0}", ex.Message);
			}
			catch (ArgumentOutOfRangeException ex)
			{
				Console.WriteLine("Exception thrown: {0}", ex.Message);
			}
			try
			{
				Person tooOldForThisPogram = new Person("Iskren", "Ivanov", 121);
			}
			catch (ArgumentNullException ex)
			{
				Console.WriteLine("Exception thrown: {0}", ex.Message);
			}
			catch (ArgumentOutOfRangeException ex)
			{
				Console.WriteLine("Exception thrown: {0}", ex.Message);
			}
		}
	}
}
