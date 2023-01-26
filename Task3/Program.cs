// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//
// 6, 1, 33 -> [6, 1, 33]

Random rand = new Random();

void Output(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(0, 50);
    }
    Console.WriteLine("[" + string.Join(", ", array) + "]");
}

int[] array = new int[8];
Output(array);

// // Напишите программу, которая задаёт массив из N элементов и выводит их на экран.

// Random rand = new Random();

// void Output(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = rand.Next(0, 50);
//     }
//     Console.WriteLine("[" + string.Join(", ", array) + "]");
// }

// int InputNumber(string str)
// {
//     int number;
//     string? text;
//     while (true)
//     {
//         Console.Write(str);
//         text = Console.ReadLine();
//         if (int.TryParse(text, out number))
//         {
//             break;
//         }

//         System.Console.WriteLine("Введено некорректное число, попробуйте ещё раз!");
//     }
//     return number;
// }

// int N = InputNumber("Введите количество элементов массива: ");
// int[] array = new int[N];
// Output(array);
