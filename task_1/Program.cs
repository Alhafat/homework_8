// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] GetArray()
{
    int[,] array = new int[3, 3];
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

void newArraySummNumbersRow(int[,] numbers)
{
    for (int k = 0; k < numbers.GetLength(0); k++)
    {
        for (int j = 0; j < numbers.GetLength(0); j++)
        {
            for (int i = 1; i < numbers.GetLength(1); i++)
            {
                if (numbers[j, i] > numbers[j, i - 1])                                   
                {                                                                
                    int temp = numbers[j, i];
                    numbers[j, i] = numbers[j, i - 1];
                    numbers[j, i - 1] = temp;
                }
            }
        }
    }
}


void main()
{
    int[,] numbers = GetArray();
    printArray(numbers);
    System.Console.WriteLine();
    newArraySummNumbersRow(numbers);
    printArray(numbers);

}

main();