// Напишите программу, которая найдёт точку пересечения двух прямых
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем

double pointX;
double pointY;

Console.Write("Даны прямые заданные формулами y = k1 * x + b1, y = k2 * x + b2");
Console.Write("Введите по очереди b1, k1, b2 и k2 одной строкой через пробел: ");
int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
int a = arr [1];
int b = arr [3];
int c = arr [0];
int d = arr [2];

if (a == b)
{
    Console.WriteLine("Прямые с такими параметрами паралельны");
}
else
{
    pointX = (double) (d-c)/(a-b);
    pointY = (double) a*(d-c)/(a-b) + c;
    Console.WriteLine("Координаты точки пересечения двух прямых:");
    Console.WriteLine($"Х: {pointX:0.00}");
    Console.WriteLine($"Y: {pointY:0.00}");
}

// №43 Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)
//(Задание со звездочкой) Найдите площадь треугольника образованного пересечением 3 прямых
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num= int.Parse(Console.ReadLine()??"0");
    return num;
}

int b1=ReadData ("Введите координату b1:");
int b2=ReadData ("Введите координату b2:");
int k1=ReadData ("Введите координату k1:");
int k2=ReadData ("Введите координату k2:");

double QuterTest(int x,int y)
{
    double x = (-b2 + b1)/(-k1 + k2);
    double y = k2 * x + b2;
    return 0;
}
// Печатаем результат
void PrintResult(string msg)
{
   Console.WriteLine (msg);
}



int res =QuterTest(x,Y);
Console.WriteLine($"две прямые пересекутся в точке с координатами X: {x}, Y: {y}");


