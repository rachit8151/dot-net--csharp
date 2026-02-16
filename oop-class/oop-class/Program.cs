// See https://aka.ms/new-console-template for more information

//Structure of a C# program
/*
namespace Object_Oriented_Programming
{
	public class OOPs
	{
		public static void Main(string[] args)
		{

		}
	}
}
*/
var p1 = new Person("Rachit", "Patel", new DateOnly(2005, 07, 15));
var p2 = new Person("Kenil", "Patel", new DateOnly(2003, 06, 30));

List<Person> people = [p1, p2];

Console.WriteLine(people.Count);

public class Person(string firstName, string lastName, DateOnly birthday)
{
	public string firstName { get; } = firstName;
	public string lastName { get; } = lastName;
	public DateOnly birthday { get; } = birthday;
}

