/* Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5 */

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int number_of_digits = 0;

for (int i = num; i != 0; i/=10)
{
    number_of_digits++;
}

Console.WriteLine(number_of_digits);

/* 2 способ через логарифм  */

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine((int) Math.Log10(num) + 1); 