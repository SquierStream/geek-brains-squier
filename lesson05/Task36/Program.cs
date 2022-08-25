// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

Console.WriteLine("Введите размер одномерного массива:");
int size = Convert.ToInt32(Console.ReadLine());
int[] n = new int[size];
FillArrayRandomn(n);
Console.WriteLine("Например, массив выглядит так: ");
PrintArray(n);
int sum = 0;

for (int z = 0; z < n.Length; z+=2)
    sum = sum + n[z];

    Console.WriteLine($"И сумма элементов на нечётных позициях {sum}");

void FillArrayRandomn(int[] n)
{
    for(int i = 0; i < n.Length; i++)
        {
            n[i] = new Random().Next(1,10);
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