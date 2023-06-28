/*Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/

/* Формула вычисления 
x = -(b2 - b1) / (k1 - k2)
y = k1 * x + b1 */

Console.Write("Введите координату x точки b1: "); 
    double b1 = Convert.ToInt32(Console.ReadLine()!);  
Console.Write("Введите координату y точки b2: "); 
    double k1 = Convert.ToInt32(Console.ReadLine()!); 
Console.Write("Введите координату x точки k1: "); 
    double b2 = Convert.ToInt32(Console.ReadLine()!);
Console.Write("Введите координату y точки k2: "); 
    double k2 = Convert.ToInt32(Console.ReadLine()!);  


double intersX = -(b1 - b2) / (k1 - k2);
double intersY = k1 * intersX + b1;  
Console.WriteLine($"Точка пересечения прямых = ({intersX} ; {intersY})");
