// Задайте одномерный массив из 123 случайных чисел в диапазоне [0, 150]. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

int[] GetRandomArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(leftRange, rightRange + 1);
    }
    return array;
}

int CountNumber(int[] massive, int minNumber, int maxNumber)
{
    int count = 0;
    for (int index = 0; index < massive.Length; index++)
    {
        if (massive[index] >= minNumber && massive[index] <= maxNumber) count++;
    }
    return count;
}

const int sizeArray = 123;
const int leftGrade = 0;
const int rightGrade = 150;
const int min = 10;
const int max = 99;

int[] arr = GetRandomArray(sizeArray, leftGrade, rightGrade);
Console.WriteLine(string.Join(" ", arr));

int countNum = CountNumber(arr, min, max);
Console.WriteLine(countNum);