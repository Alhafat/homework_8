// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


int[,] GetArray1()
{
    // int[,] array = new int[2, 2];
    int[,] array = {
                    {2, 4},
                    {3, 2}
                    };
    // for (int i = 0; i < array.GetLength(0); i++)
    // {
    //     for (int j = 0; j < array.GetLength(1); j++)
    //     {
    //         array[i, j] = new Random().Next(0, 5);
    //     }
    // }
    return array;
}

int[,] GetArray2()
{
    // int[,] array = new int[2, 2];
    int[,] array = {
                    {3,4},
                    {3,3}
                    };
    // for (int i = 0; i < array.GetLength(0); i++)
    // {
    //     for (int j = 0; j < array.GetLength(1); j++)
    //     {
    //         array[i, j] = new Random().Next(0, 5);
    //     }
    // }
    return array;
}

int[,] getProductNumbersArray(int[,] numbers1, int[,] numbers2)
{
    int[,] productNumbersArray = new int[numbers1.GetLength(0), numbers2.GetLength(1)];
    for (int k = 0; k < numbers1.GetLength(0); k++)
    {
        for (int column = 0; column < numbers2.GetLength(1); column++)
        {
            for (int row = 0; row < numbers2.GetLength(0); row++)
            {
                productNumbersArray[k, column] += numbers1[k, row] * numbers2[row, column];
            }
        }
    }
    return productNumbersArray;
}



void printArray(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            if (numbers[i, j] >= 0) Console.Write($"{numbers[i, j]}" + "\t");
            else Console.Write($"{numbers[i, j]}" + " \t");
        }
        System.Console.WriteLine();
    }
}


void main()
{
    int[,] numbers1 = GetArray1();
    System.Console.WriteLine("\n" + "Первая матрица: " + "\n");
    printArray(GetArray1());

    int[,] numbers2 = GetArray2();
    System.Console.WriteLine("\n" + "Вторая матрица: " + "\n");
    printArray(GetArray2());
    System.Console.WriteLine();

    if (numbers1.GetLength(1) == numbers2.GetLength(0))
    {
        int[,] result = getProductNumbersArray(numbers1, numbers2);
        getProductNumbersArray(numbers1, numbers2);
        printArray(getProductNumbersArray(numbers1, numbers2));
        System.Console.WriteLine();
    }
    else System.Console.WriteLine("Произведение матриц невозможно");
    // newprintArray(minSumNumbersRow, numbers);
    // System.Console.WriteLine();
}

main();
