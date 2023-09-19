// Задание № 22 Напишите программу , принемающую одно число N и выдает таблицу квадратов от 1 до N.
// Вводим число N
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num= int.Parse(Console.ReadLine()??"0");
    return num;
}
string BuildLine (int n, int Pow)
{
    string res=" ";
    for (int i = 1; i<=n; i++)
    {
        res= res + Math.Pow(i,Pow)+" ";
    }
    return res;
}
   // Печатаем результат
void PrintResult(string msg)
{
   Console.WriteLine (msg);
}
int n=ReadData ("Введите число N:");

PrintResult(BuildLine(n,2));
