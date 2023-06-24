/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных ИНДЕКСАХ.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

int[] array = GetArray(7);
Console.WriteLine($"[{String.Join(", ", array)}]");
int summ = 0;
int el = 0;

for (int i = 0; i < array.Length; i++)
{
    if (i % 2 != 0)
    {
        el = array [i];
        summ += el;
    }
}

Console.WriteLine($"Сумма элементов нечетных индексов массива = {summ}");

int[] GetArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(-10, 10);
    }
    return result;
}