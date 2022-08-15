// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Напишите число");
int number = Convert.ToInt16(Console.ReadLine());
string numberSymbol = Convert.ToString(number);

if (numberSymbol.Length > 2){
  Console.WriteLine("Третья цифра в этом числе " + numberSymbol[2]);
}
else {
  Console.WriteLine("Третья цифра отсутствует");
}