// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

string NumberRecursion(int number)
{
    if (number == 1) return $"{number}";
    return $"{number}, " + NumberRecursion(number - 1);
}

Console.Write("Введите натуральное число N: ");
int N = Convert.ToInt32(Console.ReadLine());
if (N <= 1)
{
    Console.Write("Число должо быть больше 1");
    return;
}

Console.Write(NumberRecursion(N));