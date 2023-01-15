// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// Запрос от пользователя ввода трёх целых чисел
Console.Write("Введите первое целое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе целое число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье целое число: ");
int number3 = Convert.ToInt32(Console.ReadLine());

// Примем первое число за максимальное
int max = number1;

// Сравним два оставшихся числа с max
if (number2 > max) max = number2;
if (number3 > max) max = number3;
Console.WriteLine($"max = {max}");