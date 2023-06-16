/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/


//По методу разжеванному на семинаре:


/*Console.Write("Введите пятизначное число: "); 
string number = Console.ReadLine()!;  

if(number.Length == 5)
{     
    if(number[0] == number[4] && number[1] == number[3] )
    {        
        Console.WriteLine("Ваше число палиндром");     
        }     
    else
    {         
        Console.WriteLine("Ваше число не палиндром");     
        } 
    } 
else
{     
    Console.WriteLine("Неверный ввод. Введите ПЯТИЗНАЧНОЕ число"); 
}*/



//По другому методу:


Console.Write("Введите Ваше число: ");
int num = int.Parse(Console.ReadLine()!);
int num1 = 0;
int num2 = 0;
int num3 = num / 10;
int num4 = num % 10000;
int num5 = 0;
int num6 = 0;

if (num > 10000 && num < 100000) 
{
num1 = num % 10;
num2 = num / 10000;
num5 = num3 % 10;
num6 = num4 / 1000;

if (num1 == num2 && num5 == num6)
{
Console.WriteLine("Ваше число палиндром");
}

if (num1 != num2 || num5 != num6)
{
Console.WriteLine("Ваше число не палиндром");
}
}
if (num < 10000 || num > 100000)
{
Console.WriteLine("Неверный ввод. Введите ПЯТИЗНАЧНОЕ число");
}