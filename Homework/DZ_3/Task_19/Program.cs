﻿// Задача 19: Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
//    14212 -> нет
//    23432 -> да
//    12821 -> да

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int num1 = number / 10000;
int num2 = (number % 10000) / 1000;
int num4 = (number % 100) / 10;
int num5 = number % 10;

if (num1 == num5 && num2 == num4)

    Console.WriteLine("Это число является палиндромом");
else Console.WriteLine("Это число не является палиндромом");
