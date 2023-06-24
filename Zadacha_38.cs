/*Задача 38: Задайте массив целых двухзначных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[22, 42, 15, 77, 65] => 77 - 15 = 62*/

int[] array = GetArray(10); //количество выводимых в массиве элементов
Console.WriteLine($"[{String.Join(", ", array)}]");
int max = array.Max();
int min = array.Min();

int dif = max - min;

Console.Write($"Max = {max}, Min = {min}, Разница = {dif}");

//заполнение массива
int[] GetArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(10, 100);
    }
    return result;
}