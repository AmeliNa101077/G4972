// Задание №4
//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите число 1:");
int num1 = int.Parse(Console.ReadLine()??"");
Console.WriteLine("Введите число 2:");
int num2 = int.Parse(Console.ReadLine()??"");
Console.WriteLine("Введите число 3:");
int num3 = int.Parse(Console.ReadLine()??"");
int maxNum = 0;
if (num1 > maxNum) maxNum = num1;
if (num2 > maxNum) maxNum = num2;
if (num3 > maxNum) maxNum = num3;
Console.Write("Максимальное значение имеет число " + maxNum);