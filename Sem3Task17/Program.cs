// Задание 17.Создать программу котораяпринемает на вход координаты (Х и У), определяющую в какой плоскости находится точка с координатами Х=2;у=2.
// 1) ввести Х
// 2) ввести у
// 3) поиск ответа
// 4) вывести результат
// Вводим данные
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num= int.Parse(Console.ReadLine()??"0");
    return num;
}
// По координатам точки определяем номер четверти
int QuterTest(int x,int y)
{
    if ( x > 0 && y > 0 ) return 1;
    if ( x < 0 && y > 0 ) return 2;
    if ( x < 0 && y < 0 ) return 3;
    if ( x > 0 && y < 0 ) return 4;
    return 0;
}
// Печатаем результат
void PrintResult(string msg)
{
   Console.WriteLine (msg);
}


int x=ReadData ("Введите координату Х:");
int Y=ReadData ("Введите координату Y:");
int res =QuterTest(x,Y);

PrintResult("Точка находится в четверти №"+ res);

