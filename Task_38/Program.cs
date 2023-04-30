/*
    Задача 38: 
    Задайте массив вещественных чисел. Найдите 
    разницу между максимальным и минимальным элементов массива.
    
    [3 7 22 2 78] -> 76
*/

Console.Clear();

double[] array = GetArray(5, 0, 100);
Console.WriteLine($"[ {String.Join("  ", array)} ]");

double[] GetArray(int size, int minValue, int maxValue)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round(new Random().NextDouble() * (10000 - 1) + 1) / 100;
        
    }
    return array;
}

double FindDifference(double[] array)
{
    double min = array[0];
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (min > array[i]) min = array[i];
        if (max < array[i]) max = array[i];
    }
    double dif = max - min;
    return dif;
}

Console.WriteLine($"Разница между max и min = {FindDifference(array).ToString("f2")}");
