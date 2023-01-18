// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// Запрос ввода числа у пользователя
Console.Write("Введите целое трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0) number = Math.Abs(number);
// Проверка числа и вывод второй цифры
if (number < 100 | number >= 1000)
{
    Console.WriteLine($"Число {number} не является трёхзначным");
}
else
{
    int seconddigit = (number % 100 - number % 10) / 10;
    Console.WriteLine($"Вторая цифра числа: {seconddigit}");
}