// Задайте двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int ReadNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

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

void IndexMinSumRow(int[,] matrix)
{
    int sumRow = 0;
    int minSumRow = 0;
    int index = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        minSumRow += matrix[0, j];
    }
    for (int i = 1; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumRow += matrix[i, j];
        }
        if (sumRow < minSumRow)
        {
            minSumRow = sumRow;
            index = i;
        }
        sumRow = 0;
    }
    Console.WriteLine($"{index} строка"); // для программистов
}

int m = ReadNumber("Введите количество строк: ");
int n = ReadNumber("Введите количество столбцов: ");
int minValue = ReadNumber("Введите минимальное число: ");
int maxValue = ReadNumber("Введите максимальное число: ");


int[,] array = GetRandomMatrix(m, n, minValue, maxValue);
PrintMatrix(array);
Console.WriteLine();
IndexMinSumRow(array);