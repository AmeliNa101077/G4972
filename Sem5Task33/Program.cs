// Задание 33. Задайте массив, напишите программу которая определяет присутствует ли заданное число в массиве.

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
int ReadData(string msg)
{
    Console.WriteLine(msg);
    int num= int.Parse(Console.ReadLine()??"0");
    return num;
}
int FindElmint(int[]arr,int elm)
{

for (int i=0;i < arr.Length; i++)
{
   if (arr[i]==elm)
   {
   return i;
   } 
} 
return -1;
}
int[] array=GenArray(12,-9,9);
PrintArr(array);
int elm=ReadData("Введите число для поиска:");
Console.WriteLine(FindElmint(array, elm));