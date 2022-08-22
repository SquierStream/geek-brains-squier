// Напишите метод, который задаёт массив из 8 элементов (диапазон от 1 до 100) и выводит их на экран.
int [] numbers = new int[8];
Console.Write("[");

for (int i = 0; i < numbers.Length; i++)
 {
    numbers [i] = new Random().Next(1, 101);
    Console.Write(+ Method (i) + ",");
 }
Console.Write("]");

int Method (int a)
{
    return numbers[a];
}