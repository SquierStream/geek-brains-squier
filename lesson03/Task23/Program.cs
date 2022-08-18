// Напишите метод, который принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
Console.WriteLine("Напишите число: ");
int n = Convert.ToInt32(Console.ReadLine());

void cube(int[] n){
  int counter = 0;
  int length = n.Length;
  while (counter < length){
    n[counter] = Convert.ToInt32(Math.Pow(counter, 3));
    counter++;
  }
}

void PrintArry(int[] coll){
  int count = coll.Length;
  int index = 1;
  while(index < count){
    Console.Write(coll[index]+ " ");
    index++;
  }
} 

int[] arry = new int[n+1];
cube(arry);
PrintArry(arry);