/*
Задача 68: 
Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n. Выполнить с помощью рекурсии.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

Console.Write("Введите первое число: ");
int M = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int N = int.Parse(Console.ReadLine()!);

int FnAkk = Akk(M, N);
Console.Write($"Функция Аккермана = {FnAkk} ");

int Akk(int M, int N)
{
    if (M == 0) return N + 1;
    if (N == 0) return Akk(M - 1, 1);
    else return Akk(M - 1, Akk(M, N - 1));
    }
