// See https://aka.ms/new-console-template for more information
using System.Runtime.Intrinsics.Arm;

Console.WriteLine("Hello, List<T>!");

var names = new List<string> { "Dev", "Rachit", "Kenil", "Krish",};

names.Add("Patel");

foreach(var name in names[2..4])
{
	Console.WriteLine("Hello " + name.ToUpper());
}

Console.WriteLine(names[0]);
Console.WriteLine(names[names.Count-1]); //Console.WriteLine(names[^1]);										 
										 //names[2..4] [include strat index, not include]
var numbers = new int[] { 35, 10 , 30, 15, 40, 5, 45 };
numbers = [.. numbers, 55];

numbers.Sort();

foreach (var number in numbers)
{
	Console.WriteLine(number);
}

Console.WriteLine($"After Sorting 5 at index  {numbers.IndexOf(5)}");

List<int> scores = [5, 20, 100, 3, 10, 99, 85, 45];

IEnumerable<string> scoreQuery =
	from score in scores
	where score > 80
	orderby score descending
	select $"The score is {score}";

foreach (string s in scoreQuery)
{
	Console.WriteLine(s);
}

Console.WriteLine(scoreQuery.Count());

var scoreQuery2 = scores
					.Where(s => s > 80)
					.OrderByDescending(s => s).ToList();
scores.Add(102);

foreach (int i in scoreQuery2)
{
	Console.WriteLine(i);
}


Console.ReadLine();
