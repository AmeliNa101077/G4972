// Задание 18
int QuaterBorderAsk()
{Console.WriteLine("Введите номер четверти:");
return  Convert.ToInt32(Console.ReadLine());
}

//Вводим данные
string pointsIdent(int numQut)
{
    if (numQut==1) return "Возможное значение:x>0,y>0";
    if (numQut==2) return "Возможное значение:x<0,y>0";
    if (numQut==3) return "Возможное значение:x<0,y<0";
    if (numQut==4) return "Возможное значение:x>0,y<0";
    return "Неверное значение";
}
int numQut=QuaterBorderAsk();
Console.WriteLine (pointsIdent(numQut));
