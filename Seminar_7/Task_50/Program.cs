// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// ​
// Например, задан массив:
// ​
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

int[,] GetRandomMatrix(int rows, int columns, int leftRange, int rightRange)
{
    int[,] matrix = new int[rows, columns];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(leftRange, rightRange + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

const int m = 3;
const int n = 4;
const int minValue = 0;
const int maxValue = 100;

int[,] array = GetRandomMatrix(m, n, minValue, maxValue);
PrintMatrix(array);

Console.Write("Введите индекс строки: ");
int indexRows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите индекс столбца: ");
int indexColumns = Convert.ToInt32(Console.ReadLine());

if (indexRows > m || indexColumns > n) Console.WriteLine("Такого числа в массиве нет");
else Console.WriteLine(array[indexRows, indexColumns]);