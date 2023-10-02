// Задание 32 Напишите программу, замены элементов массива(положительные замените отрицательными и наоборот)

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

void InversArr(int[]arr)
{
   for (int i=0;i < arr.Length; i++)
    {
        arr[i]=arr[i]*(-1);
    }  
}
int[] array=GenArray(12,-9,9);
PrintArr(array);
InversArr(array);
PrintArr(array);
