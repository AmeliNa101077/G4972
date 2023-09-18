// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
//(задание со *) Написать калькулятор с операциями +, -, /, * и возведение в степень

//Введем переменные
Console.WriteLine("введите число Num1");
int Num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите число Num2");
int Num2 = Convert.ToInt32(Console.ReadLine());
int step = Num1;
//Проведем расчет
for (int i = 1; i < Num2; i++)
{
step = step * Num1;
}
//Выведем результат 
Console.WriteLine("Num1 в степени Num2 равно: " + step);