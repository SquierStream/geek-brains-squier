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

int max = Math.Max(firstValue, secondValue);
max = Math.Max(max, thirdValue);
Console.WriteLine("Максимальное число " + max);
