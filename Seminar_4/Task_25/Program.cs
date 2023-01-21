// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int Exponentiation(int A, int B)
{
    int result = 1;
    for (int i = 0; i < B; i++)
    {
        result*= A;
    }
    return result;
}
Console.Write("Введите число A: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int degree = Convert.ToInt32(Console.ReadLine());
if (degree < 1)
{
    Console.WriteLine($"Степень {degree} не является натуральной");
    return;
}
int answer = Exponentiation(number, degree);
Console.WriteLine(answer);

// Использовал метод для практики