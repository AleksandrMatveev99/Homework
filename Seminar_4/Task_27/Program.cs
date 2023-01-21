// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

int ReadNumber(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int SumDigit(int remainingNumber)
{
    int sum = 0;
    while (remainingNumber != 0)
    {
        sum = sum + remainingNumber % 10;
        remainingNumber = remainingNumber / 10;
    }
    return sum;
}

int number = ReadNumber("Введите число: ");
if (number < 0) number *= -1;
int summa = SumDigit(number);
Console.WriteLine(summa);