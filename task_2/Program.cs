// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


int[,] GetArray()
{
    int[,] array = new int[6, 5];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-5, 5);
        }
    }
    return array;
}

void printArray(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            if (numbers[i, j] >= 0) Console.Write(" " + $"{numbers[i, j]}" + "\t");
            else Console.Write($"{numbers[i, j]}" + " \t");
        }
        System.Console.WriteLine();
    }
}

int[] newArraySummNumbersRow(int[,] numbers)
{
    int minSumm = (int.MaxValue);
    int[] summArray = new int[numbers.GetLength(0)];
    for (int j = 0; j < numbers.GetLength(0); j++)
    {
        for (int i = 0; i < numbers.GetLength(1); i++)
        {
            summArray[j] += numbers[j, i];
        }
    }
    return summArray;
}

void newprintArray(int[] minSumNumbersRow, int[,] numbers)
{
    int temp = int.MaxValue;
    int count = 0;
    for (int i = 0; i < minSumNumbersRow.Length; i++)
    {
        if (temp > minSumNumbersRow[i])
        {
            temp = minSumNumbersRow[i];
            count = i;
        }
    }
    System.Console.WriteLine($"Минимальная сумма элементов массива получена из {count} строки");
}

void main()
{
    int[,] numbers = GetArray();
    printArray(numbers);
    System.Console.WriteLine();

    int[] minSumNumbersRow = newArraySummNumbersRow(numbers);
    System.Console.WriteLine(string.Join(",", minSumNumbersRow));

    newprintArray(minSumNumbersRow, numbers);
    System.Console.WriteLine();
}

main();