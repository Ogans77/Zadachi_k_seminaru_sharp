﻿/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. (можно указать любой промежуток)
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

int[] getArray(int size)
{
    int[]result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(0, 46);
    }
    return result;
}

int[] array = getArray(8);
Console.WriteLine($"[{String.Join(",",array)}]");

/*int[] getArray(int size)
{
    int[]result = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write("Введите число ");
        result[i] = int.Parse(Console.ReadLine()!);
    }
    return result;
}

int[] array = getArray(8);
Console.WriteLine($"[{String.Join(",",array)}]");*/
