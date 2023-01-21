// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Данные вводятся с консоли пользователем.

void FillArray(int[] array)
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write($"A({i}): ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}

int[] arr = new int[8];
FillArray(arr);
Console.WriteLine(string.Join(" ", arr));