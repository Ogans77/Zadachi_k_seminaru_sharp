/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

Console.Write("Введите ширину массива: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите высоту массива: ");
int columns = int.Parse(Console.ReadLine()!);

Console.Write("Введите глубину массива: ");
int depth = int.Parse(Console.ReadLine()!);


int[,,] array = GetArray(rows, columns, depth, 10, 100);
PrintArray(array);

// Метод заполнения трехмерного массива 
int[,,] GetArray(int m, int n, int d, int minValue, int maxValue)

{
    int[,,] result = new int[m, n, d];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int k = 0; k < d; k++)
            {
                result[i, j, k] = new Random().Next(minValue, maxValue);
            }
        }
    }
    return result;
}

// Вывод массива
void PrintArray(int[,,] inArray)

{

    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0; k < inArray.GetLength(0); k++)
            {
                Console.Write($"{inArray[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}
