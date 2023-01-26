// Задача: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//
// 3, 5 -> 243 (3⁵)
//
// 2, 4 -> 16

int InputNumber(string str)
{
    int number;
    string? text;
    while (true)
    {
        Console.Write(str);
        text = Console.ReadLine();
        if (int.TryParse(text, out number))
        {
            break;
        }

        System.Console.WriteLine("Введено некорректное число, попробуйте ещё раз!");
    }
    return number;
}

double number = InputNumber("Введите первое число: ");
double degree = InputNumber("Введите второе число: ");

double Exp(double arg1, double arg2)
{
    double result = 1;
    for (int i = 1; i <= arg2; i++)
    {
        result = result * arg1;
    }
    return result;
}

if (degree > 0)
{
    System.Console.WriteLine($"Число {number} в степени {degree}: {Exp(number, degree)}");
}
else
{
    System.Console.WriteLine($"Число {degree} не натуральное.");
}