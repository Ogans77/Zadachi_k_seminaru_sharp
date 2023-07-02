/*Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными(тип double) числами.

m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

double[,] array2 = GetArray2(rows, columns, -10, 11);
int[,] array = GetArray(rows, columns, -100, 101);
PrintArray(array2, array);


// Метод заполнения двумерного массива целыми числами
int[,] GetArray(int m, int n, int minValue, int maxValue)

{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}

// Метод заполнения двумерного массива дробными числами
double[,] GetArray2(int m, int n, double minValue, double maxValue)
{
    double[,] result = new double[rows, columns];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(-100, 101) * 0.1;
        }
    }
    return result;
}


// Метод вывода двумерного массива
void PrintArray(double[,] inArray2, int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray2.GetLength(1); j++)
        {
            Console.Write($"{inArray[(int)i, (int)j]}   {inArray2[(int)i, (int)j].ToString("F1")}   ");
        }
        Console.WriteLine();
    }
}