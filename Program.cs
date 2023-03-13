int Num()
{Console.WriteLine(); return Convert.ToInt32(Console.ReadLine());}

/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B. Не использовать Math.Pow() и аналоги!

  int Step()
{
    int A = Num();
    int B = Num();
    int i;
    int n = A;
    for (i = 1; i < B; i++){n *= A; Console.WriteLine(n);}
    return n;
}

int a = Step();
Console.WriteLine();*/


/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.*/

/*
int N = Num();
int count = 0;
int sum = 1;
while (N > 0){N /= 10; count++;}

int[] Arrey = new int[count];
for (int i = 0; i < Arrey.Length; i++)
{
  Arrey[i] = N % 10 / 10;
  Console.WriteLine(Arrey[i]);
  sum = 1 + Arrey[i];
  console.writeline(sum);

}
*/

//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Данные вводятся с консоли пользователем

int[] N = new int[8];
for (int i = 0; i < N.Length; i++)
{
  N[i] = Num();
  Console.Write(N[i]);
}
