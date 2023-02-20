// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNumber(int firstNumber, int secondNumber)
{
    if (firstNumber == secondNumber) return firstNumber;
    return firstNumber + SumNumber(firstNumber + 1, secondNumber);
}


Console.Write("Введите натуральное число M: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите натуральное число N: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N <= M)
{
    Console.Write("Число N должно быть больше M!");
    return;
}

Console.Write(SumNumber(M, N));