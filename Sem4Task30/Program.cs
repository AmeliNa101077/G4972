﻿// Задание 30
//
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num= int.Parse(Console.ReadLine()??"0");
    return num;
}
// Генерация массива
int[] GenArr(int len)
{
    int[] arr = new int[len];
    Random rnd = new Random();
    for (int i=0;i<len;i++)
    {
        arr[i]=rnd.Next (0, 2);
    }
    return arr;
}

//Печать массива
void PrintArr(int[] arr)
{
    Console.Write("[");
    for (int i=0;i < arr.Length-1; i++)
        Console.Write ( arr[i]+",");   
   Console.WriteLine(arr[arr.Length-1] +"]");
}    

int arrLen=ReadData("Введите длинну массива");
int[] array=GenArr(arrLen);
PrintArr(array);

PrintArr(GenArr(ReadData("Введите число")));






