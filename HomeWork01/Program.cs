﻿/*Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да

*/ 
Console.WriteLine("Введите пятизначное число: ");
string number = Console.ReadLine();
int task = number.Length;

if (task == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($"{number} - Число является палиндромом :-)");
    }
    else
    {
        Console.WriteLine($"{number} - Число не является палиндромом :-(");
    }
}
else
{
    Console.WriteLine("Вы ввели не пятизначное число. Попробуйте еще раз!");
}
