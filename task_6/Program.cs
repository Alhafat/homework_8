// Задача со звездочкой:
// Написать функцию Sqrt(x) - квадратного корня, которая принимает на вход целочисленное значение x и возвращает целую часть квадратного корня от введенного числа.
// 4 -> 2
// 28 -> 5

// Нельзя использовать встроенные функции библиотеки Math!




int GetMathSqrt(int number)
{
    int count = 1;
    while (true)
    {
        if (((number - (count * count)) <= count))
        {
            System.Console.WriteLine($"Целая часть квадратного корня от числа {number} --> {count}");
            break;
        }
        count++;
    }
    return number;
}

void main()
{
    System.Console.WriteLine("Введите число:");
    int number = int.Parse(Console.ReadLine()!);
    GetMathSqrt(number);
}

main();