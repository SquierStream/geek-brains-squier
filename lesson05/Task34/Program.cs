// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

Console.WriteLine("Введите размер массива с трёхзначными числами:");
int size = Convert.ToInt32(Console.ReadLine());
int[] n = new int[size];
FillArrayRandomn(n);
Console.WriteLine("Например, массив выглядит так: ");
PrintArray(n);
int count = 0;

for (int z = 0; z < n.Length; z++)
if (n[z] % 2 == 0)
count++;

Console.WriteLine($"И в этом массиве {count} чётных чисел");

void FillArrayRandomn(int[] n)
{
    for(int i = 0; i < n.Length; i++)
    {
        n[i] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] n)
{
    Console.Write("[ ");
    for(int i = 0; i < n.Length; i++)
    {
        Console.Write(n[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}
