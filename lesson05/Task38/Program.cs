// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

Console.WriteLine("Введите размер массива вещественных чисел");
int size = Convert.ToInt32(Console.ReadLine());
double[] n = new double[size];
FillArrayRandomn(n);
Console.WriteLine("Например, массив выглядит так: ");
PrintArray(n);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int z = 0; z < n.Length; z++)
{
    if (n[z] > max)
        {
            max = n[z];
        }
    if (n[z] < min)
        {
            min = n[z];
        }
}

Console.WriteLine($"Разница между максимальным и минимальным элементами массива составляет {max - min}");

void FillArrayRandomn(double[] n)
{
    for(int i = 0; i < n.Length; i++)
        {
            n[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}
void PrintArray(double[] n)
{
    Console.Write("[ ");
    for(int i = 0; i < n.Length; i++)
        {
            Console.Write(n[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}