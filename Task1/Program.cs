// Задача: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//
// 3, 5 -> 243 (3⁵)
//
// 2, 4 -> 16

System.Console.WriteLine("Введите первое число: ");
double number = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите второе число: ");
double degree = Convert.ToInt32(Console.ReadLine());

double Exp(double arg1, double arg2)

{
    double result = Math.Pow(arg1, arg2);
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