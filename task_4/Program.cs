// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


int[,,] GetArray()
{
    int[,,] array = new int[2, 2, 2];
    // int[,,] array = new int[,,]{
    //                             {{ 66, 25},
    //                             {34, 41}},
    //                             {{27, 90},
    //                             {26, 55}}
    //                             };
    int number=0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            for (int k = 0; k < array.GetLength(2); k++)
            {
                {
                    array[i, j, k] += number++;
                }
            }
    }
    return array;
}

void printArray(int[,,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            for (int k = 0; k < numbers.GetLength(2); k++)
            {
                {
                    if (numbers[i, j, k] >= 0) Console.Write(" " + $"{numbers[i, j, k]}" + $"({i},{j},{k})" + "\t");
                    else Console.Write($"{numbers[i, j, k]}" + $"({i},{j},{k})" + " \t");
                }
            }
            System.Console.WriteLine();
        }
        System.Console.WriteLine();
    }
}


void main()
{
    int[,,] numbers = GetArray();
    System.Console.WriteLine();
    printArray(numbers);
}

main();