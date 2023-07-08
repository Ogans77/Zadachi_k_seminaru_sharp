/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

int rows = 4;
int[,] RowCol = new int[rows, rows];
int i = 0;
int j = 0;
int temp = 1;

while (temp <= RowCol.GetLength(0) * RowCol.GetLength(1))
{
    RowCol[i, j] = temp;
    temp = temp + 1;
    if (i <= j + 1 && i + j < RowCol.GetLength(1) - 1)
        j = j + 1;
    else if (i < j && i + j >= RowCol.GetLength(0) - 1)
        i = i + 1;
    else if (i >= j && i + j > RowCol.GetLength(1) - 1)
        j = j - 1;
    else
        i = i - 1;
}

WriteArray(RowCol);

void WriteArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] / 10 <= 0)
                Console.Write($" {array[i, j]} ");

            else Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
