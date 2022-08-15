// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введи цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt16(Console.ReadLine());

void dayOfWeek (int dayNumber) {
  if (dayNumber == 6 || dayNumber == 7) {
  Console.WriteLine("Можно отдыхать! Это выходной день!");
  }
  else if (dayNumber < 1 || dayNumber > 7) {
    Console.WriteLine("В неделе только 7 дней! В следующий раз пишите цифру от 1 до 7!");
  }
  else Console.WriteLine("Будний день — пора работать!");
}
dayOfWeek(dayNumber);