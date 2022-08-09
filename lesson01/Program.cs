// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Напишите первое число");
string? firstLine = Console.ReadLine();
int firstValue = Convert.ToInt16(firstLine);

Console.WriteLine("Напишите второе число");
string? secondLine = Console.ReadLine();
int secondValue = Convert.ToInt16(secondLine);

if (firstValue > secondValue) {
    Console.WriteLine("{0} > {1}", firstValue, secondValue);  // строковая интерполяция
} else if (firstValue < secondValue) {
    Console.WriteLine("{0} < {1}", firstValue, secondValue);
} else {
    Console.WriteLine("Кажется, эти числа равны!");
}
