// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Напишите первое число");
string? firstLine = Console.ReadLine();
int firstValue = Convert.ToInt16(firstLine);

Console.WriteLine("Напишите второе число");
string? secondLine = Console.ReadLine();
int secondValue = Convert.ToInt16(secondLine);

Console.WriteLine("Напишите третье число");
string? thirdLine = Console.ReadLine();
int thirdValue = Convert.ToInt16(thirdLine);

int a = firstValue;
int b = secondValue;
int c = thirdValue;
int max = Math.Max(a, b);
max = Math.Max(max, c);
Console.WriteLine("Максимальное число " + max);
Console.ReadLine();