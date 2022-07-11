/* Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36 */

int sum = 0;

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);

Console.WriteLine(GetSum(num));

/* 1 метод  */

int GetSum(int a)
{
    sum = 0;
    for (int i = 1; i <= a; i++)
    {
        sum += i;
    }
    return sum;
}

/* 2 метод  */

int GetSumFast(int a)
{
    return a * (a + 1) / 2;
}
Console.WriteLine(GetSumFast(num));

/* Console.WriteLine(int.MaxValue); вывод максимального значения
   Console.WriteLine(int.MinValue); вывод минимального */