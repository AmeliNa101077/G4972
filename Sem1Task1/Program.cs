// Задание №1
Console.WriteLine("Введите число 1:");
int num1 = int.Parse(Console.ReadLine()??"");
Console.WriteLine("Введите число 2:");
int num2 = int.Parse(Console.ReadLine()??"");
Console.WriteLine(num2==Math.Pow(num1,2)?"Да":"Нет");
