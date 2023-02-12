// Задача со звездочкой:
// Написать функцию Sqrt(x) - квадратного корня, которая принимает на вход целочисленное значение x и возвращает целую часть квадратного корня от введенного числа.
// 4 -> 2
// 28 -> 5

// Нельзя использовать встроенные функции библиотеки Math!




void GetMathSqrt(int number)
{
    int count = 1;
    while (number - (count * count) > count*2) count++;
    System.Console.WriteLine($"Целая часть квадратного корня от введенного {number} числа ---> {count}");
}

void main()
{
    System.Console.WriteLine("Введите число:");
    int number = int.Parse(Console.ReadLine()!);
    GetMathSqrt(number);
}

main();