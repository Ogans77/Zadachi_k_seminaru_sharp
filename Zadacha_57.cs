/*Задача 57: Составить частотный словарь элементов двумерного массива. 
Частотный словарь содержит информацию о том, 
сколько раз встречается элемент входных данных.

1, 2, 3

4, 6, 1

2, 1, 6

1 встречается 3 раза

2 встречается 2 раз

3 встречается 1 раз

4 встречается 1 раз

6 встречается 2 раза

*/

Console.Write("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, 0, 100);
PrintArray(array);


// Метод заполнения двумерного массива 
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

// Метод вывода двумерного массива
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

foreach (int el in array)
{
    int count = 0;
    for (int i = 0; i < array.GetLength(0); ++i)
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == el) ++count;
        }
        {
            Console.WriteLine($"Число {el.ToString()}" + " встречается" + $" {count.ToString()} раз");
        }
    Console.WriteLine();
}