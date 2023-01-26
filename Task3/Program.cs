﻿// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
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