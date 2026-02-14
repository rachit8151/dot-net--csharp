// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Loops!");

Console.WriteLine("While we dont know how many time loop will be execute");
int whileLoop = 0;

while (whileLoop < 5)
{
	whileLoop++;
	Console.WriteLine(whileLoop);
}

Console.WriteLine("Do While at leaset 1 time loop execute");

int doWhileLoop = 6;
do
{
	Console.WriteLine(doWhileLoop);
	doWhileLoop++;
} while (doWhileLoop < 5);

Console.WriteLine("For loop we know alraedy how many time loop will be execute");
for(int i = 1; i <=10; i++)
{
	int table_5 = i * 5;
	if (table_5 == 15 || table_5 == 30)
	{
		Console.WriteLine(table_5);
	}
}

Console.WriteLine("Nested For loop print as a matrix (row x column)");
for(int row = 1; row <= 8; row++)
{
	for(char column = 'A'; column <= 'H'; column++)
	{
		Console.Write(column + row.ToString() + " ");
	}
	Console.WriteLine();
}

Console.ReadLine();