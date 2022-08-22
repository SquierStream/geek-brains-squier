// Напишите метод, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());

int bSq = b;
int aSq = a;

while (b > 1){
    b = b - 1;
    a = a * aSq;
}

Console.WriteLine("Ответ:" +a);