// Напишите матод, который принимает на вход число и выдаёт сумму цифр в числе.
Console.WriteLine("Напишите число: ");
int n = Int32.Parse(Console.ReadLine());
int sum = 0;
while (n > 0){
    sum = sum + n % 10;
    n /= 10;
}

Console.WriteLine($"Сумма чисел указанного числа = {sum}");