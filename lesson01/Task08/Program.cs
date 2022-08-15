// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Напишите число");
string? getNumber = Console.ReadLine();
int n = Convert.ToInt16(getNumber);
int m = 1;

for (int i = n; i <= m; i++)
{
  if (i % 2 == 0) 
   {
   Console.Write(i + " ");
   }
}