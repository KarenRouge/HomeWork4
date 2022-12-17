// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int Exp(int A, int B){
  int result = 1;
  for(int i=1; i <= B; i++){
    result = result * A;
  }
    
    return result;
}

  Console.Write("Введите число A: ");
  int A = Convert.ToInt32(Console.ReadLine());
  Console.Write("Введите число B: ");
  int B = Convert.ToInt32(Console.ReadLine());

  int expon = Exp(numberA, numberB);
  Console.WriteLine("Ответ: " + expon);

  //Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());

  int Sum(int N){
    
    int counter = Convert.ToString(N).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++){
      advance = N - N % 10;
      result = result + (N - advance);
      N = N / 10;
    }
   return result;
  }

int sum = Sum(N);
Console.WriteLine("Сумма цифр в числе: " + sum);

//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.


