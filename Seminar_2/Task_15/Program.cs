// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// Запрос ввода числа у пользователя
Console.Write("Введите порядковый номер дня недели: ");
int number = Convert.ToInt32(Console.ReadLine());

// Проверка числа
if (number > 7)
{
    Console.WriteLine("В неделе 7 дней");
}
else
{
    if (number == 6 | number == 7 ) 
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}