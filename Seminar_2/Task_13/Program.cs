// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// Запрос ввода числа у пользователя
Console.Write("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 0) number = Math.Abs(number);

// Проверка числа
if (number < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
// Вывод третьей цифры
else
{
    // Убирать последнюю цифру до тех пор, пока число не станет трёхзначным
    while (number >= 1000)
    {
        number = (number - number % 10) / 10;
    }
    int rest = number % 10;
    Console.WriteLine($"Третья цифра числа: {rest}");
}