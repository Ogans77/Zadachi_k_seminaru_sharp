/*
Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
Выполнить с помощью рекурсии.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.Write("Введите первое число M: ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число N: ");
int N = int.Parse(Console.ReadLine()!);

void GetSumNumber(int M, int N, int sum)
{
    if (M > N)
    {
        Console.WriteLine($"Сумма чисел от M до N = {sum}");
        return;
    }
    sum += (M++);
    GetSumNumber(M, N, sum);
}

GetSumNumber(M, N, 0);