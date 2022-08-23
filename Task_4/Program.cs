// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент,
// второй и предпоследний и т.д. Результат запишите в новом массиве.

int[] CreateArray(int length, int min, int max)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
    Console.WriteLine();
}

void FindPairsElements(int[] array)
{
    int[] arr;
    if (array.Length % 2 == 0)
    {
        arr = new int[array.Length / 2];
    }
    else
        arr = new int[array.Length / 2 + 1];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = array[i] * array[array.Length - 1 - i];
    }
    if (array.Length % 2 == 1)
    {
        arr[array.Length / 2] = array[array.Length / 2];
    }
    Console.Write("Произведение пар элементов = ");
    PrintArray(arr);
}

int[] array = CreateArray(5, 0, 9);
Console.Write("Исходный массив = ");
PrintArray(array);
FindPairsElements(array);