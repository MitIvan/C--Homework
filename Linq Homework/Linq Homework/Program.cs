using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Linq_Homework
{

	public class Person
	{
		public Person(string firstName, string lastName, int age, char gender)
		{
			FirstName = firstName;
			LastName = lastName;
			Age = age;
			Gender = gender; // Tuka bese Gender (Bez vakvi trikovi :D:D:D::D)
		}

		public string FirstName { get; set; }
		public string LastName { get; set; }
		public int Age { get; set; }

		public char Gender { get; set; }
	}
		class Program
    {
        static void Main(string[] args)
        {
			List<Person> people = new List<Person>()
			{
			new Person("Bill", "Smith", 41, 'M'),
			new Person("Sarah", "Jones", 22, 'F'),
			new Person("Stacy","Baker", 21, 'F'),
			new Person("Vivianne","Dexter", 19, 'F' ),
			new Person("Bob","Smith", 49, 'M' ),
			new Person("Brett","Baker", 51, 'M' ),
			new Person("Mark","Parker", 19, 'M'),
			new Person("Alice","Thompson", 18, 'F'),
			new Person("Evelyn","Thompson", 58, 'F' ),
			new Person("Mort","Martin", 58, 'M'),
			new Person("Eugene","deLauter", 84, 'M' ),
			new Person("Gail","Dawson", 19, 'F' ),
			};

			//Task 01
			// all people aged 50 or more
			List<Person> age50 = people
									.Where(person => person.Age >= 50)
									.ToList();
			age50.ForEach(person => Console.WriteLine(person.FirstName));
			Console.WriteLine("======================================");

			// Task 02
			// all people name starts with B
			List<Person> startsB = people
										.Where(person => person.FirstName.StartsWith("B"))
										.ToList();
			startsB.ForEach(person => Console.WriteLine(person.FirstName));
			Console.WriteLine("======================================");

			// Task 03
			// first person whose surname starts with T
			Person firstT = people
								.Where(person => person.LastName.StartsWith("T"))
								.FirstOrDefault();
			Console.WriteLine(firstT == null ? "No results found" : firstT.LastName);
			Console.WriteLine("======================================");

			// Task 04
			// find youngest and oldest person
			Person youngest = people.OrderBy(person => person.Age).First();
			Person oldest = people.OrderBy(person => person.Age).Last();
			Console.WriteLine($"Youngest Person: {youngest.FirstName }, Oldest Person: {oldest.FirstName}");
			Console.WriteLine("======================================");

			// Task 05
			// find all male people aged 45 or more
			List<Person> male45 = people
										.Where(person => person.Gender == 'M')
										.Where(person => person.Age >= 45)
										.ToList();
			male45.ForEach(person => Console.WriteLine(person.FirstName));
			Console.WriteLine("======================================");
			
			// Task 06
			// find all females whose name starts with V
			List<Person> femaleV = people
										.Where(person => person.Gender == 'F')
										.Where(person => person.FirstName.StartsWith("V"))
										.ToList();
			femaleV.ForEach(person => Console.WriteLine(person.FirstName));
			Console.WriteLine("======================================");

			// Task 07
			// find last female person older than 30 whose name starts with p
			Person female30P = people
										.Where(person => person.Gender == 'F')
										.Where(person => person.FirstName.StartsWith("P"))
										.Where(person => person.Age > 30)
										.LastOrDefault();
			Console.WriteLine(female30P == null ? "No results found" : female30P.LastName);
			Console.WriteLine("======================================");

			// Task 08
			// find first male younger than 40
			Person male40 = people
								.Where(person => person.Gender == 'M')
								.Where(person => person.Age < 45)
								.FirstOrDefault();
			Console.WriteLine(male40 == null ? "No results found" : male40.LastName);
			Console.WriteLine("======================================");

			// Task 09
			// print the names of the male persons that have firstName longer than lastName
			List<string> fistNameLonger = people
												.Where(person => person.Gender == 'M')
												.Where(person => person.FirstName.Length > person.LastName.Length)
												.Select(person => person.FirstName)
												.ToList();
			fistNameLonger.ForEach(Console.WriteLine);
			Console.WriteLine("======================================");

			// Task 10
			// print the lastNames of the female persons that have odd number of ages
			List<string> femaleOdd = people
											.Where(person => person.Gender == 'F')
											.Where(person => person.Age % 2 != 0)
											.Select(person => person.LastName)
											.ToList();
			femaleOdd.ForEach(Console.WriteLine);
			Console.WriteLine("======================================");

			Console.ReadLine();
		}
	}
}
