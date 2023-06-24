/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2*/


int[] array = GetArray(10); //количество выводимых в массиве элементов
Console.WriteLine($"[{String.Join(", ", array)}]");
int even = 0;

foreach(int el in array)
{
    even += el % 2 == 0 ? 1 : 0;
}

Console.WriteLine($"Четных чисел в массиве: {even}");

//заполнение массива
int[] GetArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(100, 1000);
    }
    return result;
}