using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstactionEx01
{
	class Cow : Animal
	{
		public override void animalSound()
		{
			Console.WriteLine("The cow says: moo moo");
		}
	}
}
