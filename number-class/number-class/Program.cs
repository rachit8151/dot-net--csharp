// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, Number!");

//int x = 21000000000;
//Console.WriteLine( checked(x + x));

void Calculation()
{
	int a = 30;
	int b = 15;

	long c;

	c = (long)a + (long)b;
	Console.WriteLine("Sum of " + a + " and " + b + " is: " + c);
	c = (long)a - (long)b;
	Console.WriteLine("Sub of " + a + " and " + b + " is: " + c);
	c = (long)a * (long)b;
	Console.WriteLine("Mul of " + a + " and " + b + " is: " + c);
	c = (long)a / (long)b;
	Console.WriteLine("Div of " + a + " and " + b + " is: " + c);

}
Calculation();

int w = (int)55.5;
double x = 22.2; // natural type
float y = 12.2F;
decimal z = 21.2M; // explicit type
Console.WriteLine(" int " + w + " double " + x + " float stuffix F " + y + " decimal stuffix M " + z);

int max = int.MaxValue;
Console.WriteLine($"{max}");

Console.ReadLine();



