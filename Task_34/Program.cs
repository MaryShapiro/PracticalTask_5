/* 
   Задача 34: 
   Задайте массив заполненный случайными положительными трёхзначными числами. 
   Напишите программу, которая покажет количество чётных чисел в массиве.

   [345, 897, 568, 234] -> 2
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

int FindEvenNumbered(int[] array)
{
    int countNum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            countNum = countNum + 1;
        }
    }
    return countNum;
}

int[] Array = GetArray(10, 100, 1000);
Console.WriteLine(String.Join(" ", Array));

Console.WriteLine($"Количество чётных чисел в массиве -> {FindEvenNumbered (Array)}");