// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

int[] GetRandomArray(int size, int leftRange, int rightRange)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(leftRange, rightRange);
    }
    return array;
}

int SumOddIndex(int[] massive)
{
    int sum = 0;
    for (int index = 1; index < massive.Length; index += 2)
    {
        sum += massive[index];
    }
    return sum;
}

Console.Write("Введите длину массива: ");
int sizeArr = Convert.ToInt32(Console.ReadLine());
if (sizeArr < 2)
{
    Console.WriteLine("Число должно быть больше 2");
    return;
}

Console.Write("Введите минимальное значение: ");
int leftGrade = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение: ");
int rightGrade = Convert.ToInt32(Console.ReadLine());
if (leftGrade >= rightGrade)
{
    Console.WriteLine("Максимальное число должно быть больше минимального");
    return;
}

int[] arr = GetRandomArray(sizeArr, leftGrade, rightGrade);
Console.WriteLine(string.Join(" ", arr));

int sumNumber = SumOddIndex(arr);
Console.WriteLine(sumNumber);