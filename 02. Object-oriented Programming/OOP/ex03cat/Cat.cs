using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex03cat
{
    class Cat
    {
        string name;
        int age;
        int length;
        bool isMale;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public int Length
        {
            get { return length; }
            set { length = value; }
        }
        public bool IsMale
        {
            get { return isMale; }
            set { isMale = value; }
        }
        public Cat()
        {
            this.name = "Tom";
            this.age = 2;
            this.length = 52;
            this.isMale = true;
        }
        public Cat(string name)
        {
            this.name = name;
            //???
            this.age = 2;
            this.length = 52;
            this.isMale = true;
        }
        public Cat(string name, int age)
        {
            this.name = name;
            this.age = age;
            this.length = 52;
            this.isMale = true;
            //??
        }
        public Cat(string name, int age, int Length)
        {
            this.name = name;
            this.age = age;
            this.length = Length;
            //??
            this.isMale = true;
        }
        public Cat(string name, int age, int length, bool isMale)
        {

            this.name = name;
            this.age = age;
            this.length = Length;
            this.isMale = isMale;
            //?
        }
        public void makeSound()
        {
            Console.WriteLine("Cat {0}, age {1} with length {2} said: Meow!", name, age, length);
        }
    }
}
