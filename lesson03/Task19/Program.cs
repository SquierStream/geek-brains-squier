// Напишите метод, который принимает на вход шестизначное число и проверяет, является ли оно палиндромом.

Console.WriteLine("Введите шестизначное число: ");
string? number = Console.ReadLine();

void checkNumber(string number){
  if (number[0]==number[5] || number[1]==number[4] || number[2]==number[3]){
    Console.WriteLine($"Указанное число: {number} — палиндром.");
  }
  else Console.WriteLine($"Указанное число: {number} — НЕ палиндром.");
}

if (number!.Length == 6){
  checkNumber(number);
}
else Console.WriteLine($"Проверьте, что ввели шестизначное число!");