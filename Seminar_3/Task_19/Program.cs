// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());
int remainingNumber = number;
if (number < 0 || number == 0 || number % 10 == 0)
{
    Console.WriteLine($"Число {number} не может являться палиндромом");
    return;
}

int returnedNumber = 0;
while (remainingNumber > returnedNumber)
{
    returnedNumber = remainingNumber % 10 + returnedNumber * 10;
    remainingNumber /= 10;
}
if (remainingNumber == returnedNumber || remainingNumber == returnedNumber/10)
{
    Console.WriteLine($"Число {number} является палиндромом");
}
else
{
    Console.WriteLine($"Число {number} не является палиндромом");
}