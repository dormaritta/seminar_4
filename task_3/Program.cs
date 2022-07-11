/* Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24 
5 -> 120 */

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int factorial = 1;

for (int i = 2; i <= num; i++)
{
    factorial *= i;
}

Console.WriteLine(factorial);