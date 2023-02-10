// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 11 12 199 14
// 12 199 14 15
// 11 16 15 16
// 11 19 18 17

int[,] GetArray()
{
    int[,] matrix = new int[4, 4];
    // int[,] matrix = new int[99,99];
    // for (int i = 1; i < matrix.GetLength(1); i++)
    // {
    //     for (int j = 1; j < matrix.GetLength(1); j++)
    //     {
    //         matrix[i,j]=new Random().Next(-5,5);
    //     }
    // }
    return matrix;
}

int[,] PrinArray(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            Console.Write(numbers[i, j] + " " + "\t");
        }
        Console.WriteLine();
    }
    return numbers;
}


int[,] printNumbers(int[,] numbers)
{
    for (int row = 0; row< numbers.GetLength(0) - 3; row++)
    {
        for (int column = 0; column < numbers.GetLength(1); column++)
        {
            numbers[row, column] = new Random().Next(10, 99);
        }
    }
    for (int column = numbers.GetLength(1) - 1; column < numbers.GetLength(1); column++)
    {
        for (int row = 1; row < numbers.GetLength(0); row++)
        {
            numbers[row, column] = new Random().Next(10, 99);
        }
    }
    for (int row = numbers.GetLength(0); row > numbers.GetLength(0); row++)
    {
        for (int column = numbers.GetLength(1) - 1; column >= 0 ; column--)
        {
            numbers[row, column] = new Random().Next(10, 99);
        }
    }
    // for (int j = 1; j < numbers.GetLength(1) - 2; j++)
    // {
    //     for (int i = 1; i < numbers.GetLength(1) - 1; i++)
    //     {
    //         numbers[i,j]=new Random().Next(10,99);
    //     }
    // }
    return numbers;
}

void main()
{
    Console.Clear();
    int[,] numbers = GetArray();
    printNumbers(numbers);
    PrinArray(numbers);
    // string result = printNumbers(numbers);
    // Console.Write("\n" + result);
}

main();