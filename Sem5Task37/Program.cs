// Задание 37.Найдите произведение чисел в одномерном массиве.Пары 1 и последний элемент,2 и предпоследний,результат написать в новом массиве

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
void PrintArr(int[] arr)
{
    Console.Write("[");
    for (int i=0;i < arr.Length-1; i++)
    {
        Console.Write ( arr[i]+",");  
    }   
   Console.WriteLine(arr[arr.Length-1] +"]");
}    
int [] ConvertArr(int[] arr)
{
int []outArr = new int[arr.Length/2];
for (int i=0;i < arr.Length/2; i++)
{
    outArr[i]=arr[i]*arr[arr.Length-1-i];
}
return outArr;
}
int[] arr=GenArray(15,-6,8);
PrintArr(arr);
PrintArr (ConvertArr(arr));