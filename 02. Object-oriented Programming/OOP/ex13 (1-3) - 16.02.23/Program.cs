using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex13__1_4____16._02._23
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("\n-----ex01-----");
			Func<int, int> square = x => x * x;
			Console.WriteLine(square(5));
			Func<int, int, int> add = (x, y) => x + y;
			Console.WriteLine(add(3,4));
			Func<int, int> factorial = n =>
			{
				int result = 1;
				for (int i = 1; i <= n; i++)
				{
					result *= i;
				}
				return result;
			};
			Console.WriteLine(factorial(5));
			Console.WriteLine("\n-----ex02-----");
			List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
			var evenNumbers = from num 
							  in numbers
							  where num % 2 == 0
							  select num;
			Console.WriteLine("Even Numbers:");
			foreach(int evenNum in evenNumbers)
			{
				Console.WriteLine(evenNum);
			}
			Console.WriteLine("\n-----ex03-----");
			List<Person> people = new List<Person>{
				new Person("John", 32),
				new Person("Jane", 28),
				new Person("Jim", 40),
				new Person("Jill", 32)
			};
			people.Sort((person1, person2) => person1.Age.CompareTo(person2.Age));
			Console.WriteLine("Sorted by Age:");
			foreach(Person person in people)
			{
				Console.WriteLine($"{person.Name}, {person.Age}");
			}
			Console.WriteLine("\n-----ex04-----");
			var groupedPeople = from person in people
								group person by person.Age into ageGroup
								select new
								{
									Age = ageGroup.Key,
									People = ageGroup.ToList()
								};
			Console.WriteLine("Grouped by Age:");
			foreach(var group in groupedPeople)
			{
				Console.WriteLine($"Age: {group.Age}");
				foreach(Person person in group.People)
				{
					Console.WriteLine($"\t{person.Name}");
				}
			}
		}
	}
	class Person
	{
		public string Name { get; set; }
		public int Age { get; set; }
		public Person(string name, int age)
		{
			Name = name;
			Age = age;
		}
	}
}
