// Задание 24 из семинара
// Напишите программу , которая принемает на вход число А и выдает сумму чисел от 1 до А
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num= int.Parse(Console.ReadLine()??"0");
    return num;
}


// Печатаем результат
void PrintResult(string msg)
{
   Console.WriteLine (msg);
}
int SimpleSum (int numA)
{
        int sumOfNamber = 0;
        for (int i=1;i<numA;i++)
        {
             sumOfNamber +=i;      
        }
        return sumOfNamber ;
}
int numberA = ReadData ("Введите число А: ");
int res = SimpleSum (numberA);

PrintResult("Сумма чисел от 1 до " + numberA + " равна " + res );
