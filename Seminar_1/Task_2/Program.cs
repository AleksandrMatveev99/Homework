// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// Запрос от пользователя ввода двух чисел
Console.Write("Введите первое целое число a: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число b: ");
int number2 = Convert.ToInt32(Console.ReadLine());

// Сравнение чисел
if (number1 > number2)
{
    Console.WriteLine($"max = {number1}, min = {number2}");
}
else
{
    Console.WriteLine($"max = {number2}, min = {number1}");
}