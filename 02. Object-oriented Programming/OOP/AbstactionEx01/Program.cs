using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstactionEx01
{
	class Program
	{
		static void Main(string[] args)
		{
			Pig myPig = new Pig();
			myPig.animalSound();
			myPig.sleep();

			Cow myCow = new Cow();
			myCow.animalSound();
			myCow.sleep();
		}
	}
}
