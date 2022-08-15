//Написать метод, принимающий бинарное представление числа и возращаюшее десятичное представление числа

Console.Write("Введите бинарное число: ");
      String Number = Console.ReadLine();
      Int32 DecimalNumber = 0;
 
      for (int i = 0; i < Number.Length; i++)
      {
         if (Number[Number.Length - i - 1] == '0') continue; // Проверка на 0 - останавливаемся 
         DecimalNumber += (int)Math.Pow(2, i); // Числа возводятся в квадрат и прибавляются в одну переменную
      }
      Console.WriteLine("Число в десятичном представлении: " + DecimalNumber);