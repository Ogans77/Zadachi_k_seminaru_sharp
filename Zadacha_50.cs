/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
i = 1, j = 2 -> 2
i = 4, j = 2 -> такого элемента не существует
*/

Console.Write("Введите искомую строку в массиве: ");
int A = int.Parse(Console.ReadLine()!);

Console.Write("Введите искомый столбец в массиве: ");
int B = int.Parse(Console.ReadLine()!);

int rows = new Random().Next(3, 10);
int columns = new Random().Next(3, 10);


int[,] array = GetArray(rows, columns, -100, 101);
PrintArray(array);

if(A > rows || B > columns)
{
    {
    Console.WriteLine($"Ваш искомый элемент отсутствует в массиве");
}
Console.WriteLine();
}

// Метод заполнения двумерного массива 
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m,n];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            result[i,j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}

// Метод вывода двумерного массива
void PrintArray(int[,] inArray)
{
    for(int i = 0; i < inArray.GetLength(0); i++)
    {
        for(int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]}   ");
        }
        Console.WriteLine();
    }
}

// Поиск искомого элемента
int elementValue = array[A, B];
if(elementValue == array[A, B])
{
    Console.WriteLine($"Ваш искомый элемент = {elementValue}");
}



