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

int CountEvenNumber(int[] massive)
{
    int count = 0;
    for (int index = 0; index < massive.Length; index++)
    {
        if (massive[index] % 2 == 0) count++;
    }
    return count;
}

Console.Write("Введите длину массива: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());
if (sizeArray<1)
{
    Console.WriteLine("Введите натуральное число");
    return;
}

int[] arr = GetRandomArray(sizeArray, 100, 999);
Console.WriteLine(string.Join(" ", arr));

int countNumber = CountEvenNumber(arr);
Console.WriteLine(countNumber);