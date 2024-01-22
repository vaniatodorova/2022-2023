using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstactionEx01
{
	class Pig : Animal
	{
		public override void animalSound()
		{
			Console.WriteLine("The pig says: wee wee");
		}
	}
}
