// Задание 11
// Введите трехзначное число и удалите из него вторую цифру.
int num = new Random().Next(100,1000);
Console.WriteLine(num);
int firstDigit=num/100;
int lastDigit = num%10;
num = firstDigit*10+lastDigit;
Console.WriteLine(num);
