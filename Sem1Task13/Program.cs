// Задание № 13
Console.WriteLine("Введите первое число:");
int numA = int.Parse(Console.ReadLine()??"0");

Console.WriteLine("Введите второе число:");
int numB = int.Parse(Console.ReadLine()??"0");

 Console.WriteLine(numB%numA==0?"Второе число кратно первому":"остаток от деления:"+(numB%numA));