using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstactionEx01
{
	abstract class Animal
	{
		public abstract void animalSound();
		public void sleep()
		{
			Console.WriteLine("Zzz");
		}
	}
}
