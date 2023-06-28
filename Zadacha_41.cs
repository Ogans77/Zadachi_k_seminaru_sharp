/*Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/


//Задание длины и заполнение массива пользователем
Console.Write("Задайте количество вводимых чисел: ");
int size = int.Parse(Console.ReadLine()!);

int[] number = new int[size];
int i = 0;
while (i < size)
{
    Console.Write("Введите Ваши числа: ");
    number[i] = int.Parse(Console.ReadLine()!);
    Console.WriteLine();
    i++;
}

//Поиск чисел больше нуля
int even = 0;
foreach(int el in number)
{
    even += el > 0 ? 1 : 0;
}

Console.WriteLine($"Положительных чисел (> 0) в массиве: {even}");