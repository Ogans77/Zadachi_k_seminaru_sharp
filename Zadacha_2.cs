//Задача 2: Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.

Console.Write("введите первое число: ");
int numberA = int.Parse(Console.ReadLine()!);
Console.Write("введите второе число: ");
int numberB = int.Parse(Console.ReadLine()!);

if(numberA > numberB)
{
Console.WriteLine ("Первое число большее, второе число меньшее");
}

if(numberA < numberB)
{
Console.WriteLine ("Первое число меньшее, второе число большее");
}

