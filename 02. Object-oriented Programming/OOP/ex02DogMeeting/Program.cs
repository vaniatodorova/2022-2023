using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex02DogMeeting
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstDogName = null;
            Console.WriteLine("Write first dog name: ");
            firstDogName = Console.ReadLine();
            Dog firstDog = new Dog(firstDogName);
            Dog secondDog = new Dog();
            Console.WriteLine("Write second dog name: ");
            string secondDogName = Console.ReadLine();
            secondDog.Name = secondDogName;
            Dog thirdDog = new Dog();
            Dog[] dogs = new Dog[] { firstDog, secondDog, thirdDog };
            foreach(Dog dog in dogs)
            {
                dog.Bark();
            }
        }
    }
}
