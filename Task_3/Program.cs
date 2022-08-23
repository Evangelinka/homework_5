// Задайте массив вещественных чисел. Найдите разницу между максимальным 
// и минимальным элементов массива.

double[] CreateArray(int length)
{
    double[] array = new double[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().NextDouble() * 10;
    }
    return array;
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{Math.Round(array[i], 2)} ");
    Console.WriteLine();
}

double FindMinNumber(double[] array)
{
    double min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min)
            min = array[i];
    }
    return min;
}

double FindMaxNumber(double[] array)
{
    double max = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
            max = array[i];
    }
    return max;
}

double DifferenceMaxMin(double resMin, double resMax)
{
    double result = 0;
    result = resMax - resMin;
    return result;
}

double[] array = CreateArray(5);
PrintArray(array);
double resMin = FindMinNumber(array);
Console.WriteLine($"Минимальное значение = {Math.Round(resMin, 2)}");
double resMax = FindMaxNumber(array);
Console.WriteLine($"Максимальное значение = {Math.Round(resMax, 2)}");
double res = DifferenceMaxMin(resMin, resMax);
Console.WriteLine($"Разница между максимальным и минимальным значениями в массиве = {Math.Round(res, 2)}");