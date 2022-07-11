/* Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0] */

int[] array = new int[8];
int length = array.Length;

for (int i = 0; i < length; i++)
{
    array[i] = new Random().Next(0, 2);
}

foreach (var item in array)
{
    Console.Write(item + " ");
}

/* Функция заполняющая рандомный массив */

void FillArrayRandom(int[] massivchik);
{
    for (int i = 0; i < massivchik.Length; i++)
    {
        massivchik[i] = new Random().Next(0, 2); //можно без нуля
    }
}

void ShowArray(int[] massivchik);
{
    foreach (var item in massivchik)
    {
        Console.Write(item + " ");
    }
}

FillArrayRandom(array);
ShowArray(array);

/* Вторая функция которая принимает размер и возвращает массив */

int [] GetArrayRandom (int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 2); //можно без нуля
    }
    return array;
}

int[] massivus = GetArrayRandom(8);
ShowArray(massivus);