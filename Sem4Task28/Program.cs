// Задание 28.Напишите программу ,которая принемает на вход число N и выводит произведение чисел от 1 до N
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num= int.Parse(Console.ReadLine()??"0");
    return num;
}
long Factorial(int num)
{
    long res=1;
    for(int i =2;i<=num;i++)
    {
        res=res*i;
    }
    return res;
}



// Печатаем результат
void PrintResult(string msg)
{
   Console.WriteLine (msg);
}

int num=ReadData ("Введите число:");
long res = Factorial(num);
PrintResult("Произведение всех цифр данного числа равно: "+ res );