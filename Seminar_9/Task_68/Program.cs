// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

int Ackerman(int firstNumber, int secondNumber)
{
    if (firstNumber == 0) return secondNumber + 1;
    else if (firstNumber > 0 && secondNumber == 0) return Ackerman(firstNumber - 1, 1);
    return Ackerman(firstNumber - 1, Ackerman(firstNumber, secondNumber - 1));
}

Console.Write("Введите натуральное число m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите натуральное число n: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n < 0 || m < 0)
{
    Console.Write("Число должно быть неотрицательным");
    return;
}

Console.Write(Ackerman(m, n));