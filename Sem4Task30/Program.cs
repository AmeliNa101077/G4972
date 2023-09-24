// Задание 30
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
    int[] arr = num int[len];
    Random rnd = num Random();
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
}   Console.WritLine ( arr[arr.Length-1] +"]");
    PrintArry(GenArr);






