// See https://aka.ms/new-console-template for more information
Console.WriteLine("         Hello, Patel!");

string firstName = "    Rachit";
string middleName = "K";
string lastName = "    Patel    ";
Console.WriteLine($"Full Name: {firstName.TrimStart()} {middleName} {lastName.Trim()}");

string friendName = "Kenil    ";
Console.WriteLine("My Friend Name is : " + friendName.TrimEnd()  + ".");

string fullName = $"Full Name: {firstName.TrimStart()} {middleName} {lastName.Trim()}";

fullName = fullName.Replace("K", "Khushalbhai");

//Console.WriteLine(fullName);

Console.WriteLine("upper case ".ToUpper() + friendName.ToUpper());
Console.WriteLine("LOWER CASE ".ToLower());

Console.WriteLine(fullName.Length);

Console.WriteLine(friendName.StartsWith("K"));
Console.WriteLine(friendName.EndsWith("l"));

Console.ReadLine();
