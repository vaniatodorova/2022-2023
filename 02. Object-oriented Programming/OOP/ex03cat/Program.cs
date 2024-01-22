using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex03cat
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat myCat = new Cat();
            Cat myCat02 = new Cat("Jim");
            Cat myCat03 = new Cat("Kiro",5);
            Cat myCat04 = new Cat("Joro",3,55);
			Cat myCat05 = new Cat("Stanka",4, 51, false);
            myCat.makeSound();
            myCat02.makeSound();
            myCat03.makeSound();
            myCat04.makeSound();
            myCat05.makeSound();
        }
    }
}
