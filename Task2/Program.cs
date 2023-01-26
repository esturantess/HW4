// Задача: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//
// 452 -> 11
//
// 82 -> 10
//
// 9012 -> 12

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

int Sum(int arg1)
{
    int result = 0;
    while (arg1 > 0)
    {
        result = result + (arg1 % 10);
        arg1 = arg1 / 10;
    }
    return result;
}

int A = InputNumber("Введите число: ");
System.Console.WriteLine($"Сумма чисел в числе {A}: {Sum(A)}");