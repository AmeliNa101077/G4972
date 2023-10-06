// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07

int len = 4;
int[,] table = new int[len, len];
FillArraySpiral(table, len);
PrintArray(table);


//  Функция заполнения массива по спирали начиная с 1
void FillArraySpiral(int[,] array, int n)
{
    int i = 0, j = 0;
    int value = 1;
    for (int e = 0; e < n * n; e++)
    {
        int k = 0;
        do { array[i, j++] = value++; } while (++k < n - 1);
        for (k = 0; k < n - 1; k++) array[i++, j] = value++;
        for (k = 0; k < n - 1; k++) array[i, j--] = value++;
        for (k = 0; k < n - 1; k++) array[i--, j] = value++;
        ++i; ++j;
        n = n < 2 ? 0 : n - 2;
    }
}

//  Функция вывода двумерного массива в терминал
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < 10)
            {
                Console.Write("0" + array[i, j]);
                Console.Write(" ");
            }
            else Console.Write(arraЗадайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Внутри класса Answer напишите метод CreateRandomMatrix, который принимал бы числа m и n (размерность массива), а также minLimitRandom и maxLimitRandom, которые указывают на минимальную и максимальную границы случайных чисел.

Также, задайте метод PrintArray, который выводил бы массив на экран.

Для вывода матрица используйте интерполяцию строк для форматирования числа matrix[i, j] с двумя знаками после запятой (f2) и добавления символа табуляции (\t) после каждого элемента матрицы. Таким образом, каждый элемент матрицы будет разделен символом табуляции при выводе.

m = 3, n = 4, minLimitRandom = -10,y[i, j] + " ");
        }
        Console.WriteLine();
    }
}