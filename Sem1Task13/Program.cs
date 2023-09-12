//Задание № 13
// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
//Вводим число
Console.WriteLine("Введите число :");
int num = int.Parse(Console.ReadLine()??"");
// Находим третью цифру числа.
int thirdDigit = GetThirdDigit(num);
if (thirdDigit != -1)
{
    Console.WriteLine("Третья цифра числа: " + thirdDigit);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}
Console.ReadLine();
static int GetThirdDigit(int num)
{
    int digitCount = GetDigitCount(num);
    if (digitCount >= 3)
    {
        int divider = (int)Math.Pow(10, digitCount - 3);
        return (num / divider) % 10;
    }
    return -1;
}
static int GetDigitCount(int num)
{
    int count = 0;
    int temp = num;
    while (temp != 0)
    {
        temp /= 10;
        count++;
    }
    return count;
}