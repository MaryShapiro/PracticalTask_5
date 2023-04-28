﻿/*
   Задача 36: Задайте одномерный массив, заполненный случайными числами. 
   Найдите сумму элементов, стоящих на нечётных позициях.

   [3, 7, 23, 12] -> 19

   [-4, -6, 89, 6] -> 0
*/

Console.Clear();

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}

int SumOddNumber(int[] Array)
{
    int oddNum = 0;
    for (int i = 0; i < Array.Length; i = i + 2)
    {
        oddNum += Array[i];
    }
    return oddNum;
}

int[] Array = GetArray(4, -100, 100);
Console.WriteLine(String.Join(" ", Array));

Console.WriteLine($"Сумма чисел, стоящих на нечётных позициях -> {SumOddNumber(Array)}");
