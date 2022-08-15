// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.WriteLine("Напишите трёхзначное число");
int threeDigit = Convert.ToInt16(Console.ReadLine());
string stringNumber = Convert.ToString(threeDigit);

Console.WriteLine("Вторая цифра этого числа "+stringNumber[1]);