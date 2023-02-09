// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. 
// Ввод чисел останавливается при помощи ввода стоп-слова "stop" и производится при помощи нажатия Enter
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

int countPositive(int size)
{
    int[] array = new int[size];
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        string? number = Console.ReadLine();
        if (number == "stop")
        {
            break;
        }
        array[i] = Convert.ToInt32(number);
        if (array[i] > 0) count++;
    }
    return count;
}

Console.Write("Введите M: ");
int M = Convert.ToInt32(Console.ReadLine());

int countNumber = countPositive(M);
Console.WriteLine($"Ответ: {countNumber}");