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
        for (int i = 1;i<=numA;i++)
        {
             sumOfNamber +=i;      
        }
        return sumOfNamber ;
}
int GausseSum (int numA)
{
    int sumOfNamber = 0;
    sumOfNamber=(numA*(numA+1))/2;  
    return sumOfNamber ;
}
int numberA = ReadData ("Введите число А: ");

    DateTime d1=DateTime.Now;
    int res1 = SimpleSum(numberA);
    Console.WriteLine(DateTime.Now-d1);

    DateTime d2=DateTime.Now;
    int res2=GausseSum(numberA);
    Console.WriteLine(DateTime.Now-d2);


PrintResult("Сумма чисел от 1 до " + numberA + " (простой)равна " + res1 );
PrintResult("Сумма чисел от 1 до " + numberA + " (Гаусса)равна " + res2 );