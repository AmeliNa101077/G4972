// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
//(задание со *) Написать калькулятор с операциями +, -, /, * и возведение в степень

//Введем переменные
//Console.WriteLine("введите число Num1");
//int Num1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("введите число Num2");
//int Num2 = Convert.ToInt32(Console.ReadLine());
//int step = Num1;
//Проведем расчет
//for (int i = 1; i < Num2; i++)
//{
//step = step * Num1;
//}
//Выведем результат 
//Console.WriteLine("Num1 в степени Num2 равно: " + step);

//Задание со звездочкой

//Вводим данные
string ReadData(string msg)
{
    Console.WriteLine(msg);
    string data = Console.ReadLine();
    return data;
}
//Функция сложения
long plus (int a, int b)
{
    long result = a + b;
    return result;
}
//Функция вычитания
long minus (int a, int b)
{
    long result = a - b;
    return result;
}
//Функция умножения
long multiplication (int a, int b)
{
    long result = a*b;
    return result;
}
//Функция деления
long division (int a, int b)
{
    long result = a/b;
    return result;
}
//Функция возведения в степень
long degree (int a, int b)
{
    long result = a^b;
    return result;
}
// Печатаем результат 
void PrintResult (string msg)
{
    Console.WriteLine(msg);
}
int a =int.Parse(ReadData("Введите число A"));
int b =int.Parse(ReadData("Введите число B"));
string operand =ReadData("Введите операцию (+,-,*,/,^)");

long result=0;
switch(operand)
{
    case "+":
    result=plus(a,b);
    break;
    case "-":
    result=minus(a,b);
    break;
    case "*":
    result=multiplication(a,b);
    break;
    case "/":
    result=division(a,b);
    break;
    case  "^":
    result=degree(a,b);
    break;
    default:Console.WriteLine("Что-то пошло не так");
    break;
}
PrintResult("Результат операции="+ result );