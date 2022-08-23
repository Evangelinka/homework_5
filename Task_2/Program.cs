// Задайте одномерный массив, заполненный случайными числами. Найдите
// сумму элементов, стоящих на нечетных позициях.

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

void FindSumOddIndexes(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1)
        {
            sum += array[i];
        }
    }
    Console.WriteLine($"Сумма элементов, которые стоят на нечетных позициях = {sum}");
}

int[] array = CreateArray(8, -10, 10);
PrintArray(array);
FindSumOddIndexes(array);