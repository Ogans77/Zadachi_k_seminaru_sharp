//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите три числа: ");
int numberA = int.Parse(Console.ReadLine()!);
int numberB = int.Parse(Console.ReadLine()!);
int numberC = int.Parse(Console.ReadLine()!);
int max = numberA;

if (max < numberB)
    max = numberB;
if (max < numberC)
    max = numberC;
{
Console.Write ($"Максимальное число: {max}");
}
