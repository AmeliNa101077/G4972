﻿// Задача 35   Задайте одномерный массив из 123 случайных чисел и найдте количество элементов находящихся в промежутке от 10 до 99
//заполняем одномерный массив
int[] GenArray(int num,int LowBorder,int highBorder)
{
    int[] array = new int[num];
    Random rnd = new Random();
    for (int i=0;i<num;i++)
    {
        array[i]=new Random().Next(LowBorder,highBorder+1);
    }
    return array;
}

//печать массива
void PrintArrey(int[] arr)
{
    Console.Write("[");
    for (int i=0;i < arr.Length-1; i++)
    {
        Console.Write ( arr[i]+",");  
    }   
   Console.WriteLine(arr[arr.Length-1] +"]");
}   
// Находим количество элементов в заданном диапазоне
int CountElm(int[] arr, int x, int y)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] >= x && arr[i] <= y)
        {
            count++;
        }
    }
    return count;
}

//Печатаем результат
void PrintResult(string msg)
{
    Console.WriteLine(msg);
}

// Вызываем генерацию массива, выводим изначальный массив, инвертируем массив и выводим инвертированный массив
int[] array = GenArray(123, 0, 1000);
PrintArrey(array);
int x = 10;
int y = 99;
int count = CountElm(array, x, y);
PrintResult($"{count} элементов в заданном диапазоне");