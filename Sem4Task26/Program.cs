// Задание 26.
//Напишите программу которая принемает на вход число и выдает колличество цифр числа.
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num= int.Parse(Console.ReadLine()??"0");
    return num;
}
int NumDigts(int num)
{
    int count = 0 ;
    while(num>0)
    {
        count++;
        num=num/10;
    }
    return count;
}


// Печатаем результат
void PrintResult(string msg)
{
   Console.WriteLine (msg);
}

int num=ReadData ("Введите число:");
int res = NumDigts(num);
PrintResult("Данное число состоит из "+ res + " цифр");