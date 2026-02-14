// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Conditional Logic!");

int age = 20;
bool hasLicense = true;

if (age >= 18 && hasLicense)
{
	Console.WriteLine("You can drive.");
}
else if (age >= 18 && !hasLicense)
{
	Console.WriteLine("You are 18+, but no license.");
}
else
{
	Console.WriteLine("You are under 18.");
}
Console.ReadLine();