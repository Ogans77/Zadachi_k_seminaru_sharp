﻿//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());
int N_nul = 2;

while (N_nul <= N){
    Console.Write($"{N_nul} ");
    N_nul += 2;
}