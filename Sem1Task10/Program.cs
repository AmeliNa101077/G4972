﻿// Задание № 10
// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
// Введем трехзначное число.
Console.Write("Введите трехзначное число number :");
int number = int.Parse(Console.ReadLine()??"");
//Определим вторую цифру числа.Выводим результат.
if (number >=100&&number<1000)
{
    int mid =((number % 100-number % 10)/10);

    System.Console.WriteLine("Вторая цифра числа " + number + " является " + mid);
}
else
System.Console.WriteLine("Это число не трехзначное");