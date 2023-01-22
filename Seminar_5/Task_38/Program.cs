// Задайте массив натуральных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

int[] GetRandomArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(leftRange, rightRange + 1);
    }
    return array;
}

int MaxNumber(int[] massive)
{
    int max = massive[0];
    for (int i = 1; i < massive.Length; i++)
    {
        if (massive[i] > max) max = massive[i];
    }
    return max;
}

int MinNumber(int[] massive)
{
    int min = massive[0];
    for (int i = 1; i < massive.Length; i++)
    {
        if (massive[i] < min) min = massive[i];
    }
    return min;
}

// int DiffMinMax(int[] arrayNumber)
// {
//     int max = arrayNumber[0];
//     int min = arrayNumber[0];
//     for (int index = 1; index < arrayNumber.Length; index++)
//     {
//         if (arrayNumber[index] > max) max = arrayNumber[index];
//         else if (arrayNumber[index] < min) min = arrayNumber[index]; 
//     }
//     Console.WriteLine($"max = {max}");
//     Console.WriteLine($"min = {min}");
//     int diff = max - min;
//     return diff;
// }

Console.Write("Введите длину массива: ");
int sizeArr = Convert.ToInt32(Console.ReadLine());
if (sizeArr < 2)
{
    Console.WriteLine("Число элементов должно быть >= 2");
    return;
}

const int leftGrade = 1;

Console.Write("Введите максимальное значение элементов: ");
int rightGrade = Convert.ToInt32(Console.ReadLine());
if (rightGrade < 1)
{
    Console.WriteLine("Введите число >= 1");
    return;
}
int[] arr = GetRandomArray(sizeArr, leftGrade, rightGrade);
Console.WriteLine(string.Join(" ", arr));

int maxValue = MaxNumber(arr);
Console.WriteLine($"max = {maxValue}");

int minValue = MinNumber(arr);
Console.WriteLine($"min = {minValue}");

int result = maxValue - minValue;
// int result = DiffMinMax(arr);
Console.WriteLine(result);

// Решил задачу двумя способами (второй способ закомментировал). 
// Во втором способе использовал один метод DiffMinMax вместо двух - MaxNumber и MinNumber. 
// Но вспомнил, что ты вроде говорил, что не принято в одном методе выводить в консоль что-либо и возвращать значение. 