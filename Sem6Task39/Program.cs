// Задание 39 Напишите программу,которая перевернет одномерный массив ( последний элемент будет на первом месте,а первый на последнем)

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
void SwapNewArray(int[]arr)
{
    int[]outArr=new int [arr.Length];
    for (int i = 0;i<arr.Length;i++)
    {
        outArr[arr.Length-1-i]=arr[i];
    }
}    return outArr;
int [] arr=GenArray(15,1,100);
PrintArr(arr);
int [] swapArr=SwapNewArray (arr);
Console.WriteLine("исходный массив: ");
PrintArr(arr);
Console.WriteLine("перевернутый массив");
PrintArr("",swapArr);
SwapArray(arr);
Console.WriteLine("Исходный массив");
PrintArray("",arr);