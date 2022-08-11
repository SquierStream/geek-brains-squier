// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Напишите число");
string? getNumber = Console.ReadLine();
int number = Convert.ToInt16(getNumber);

 if (number % 2 == 0) {
    Console.Write("Введенное число является четным");
    Console.Read();
} else {
    Console.Write("Введенное число нечетное");
    Console.Read();
}
