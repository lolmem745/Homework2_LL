Console.Write("Введите число: ");

int thirdDigit(int a)
{
    int depth = numberDepth(a);
    if (a >= 100)
    {
        while (depth > 3)
        {
            a = a / 10;
            depth--;
        }
        a = a % 10;
        return a;
    }
    else
    {

        return -1;
    }
}

int numberDepth(int num)
{
    if (num == 0)
        return 1;

    var result = 0;
    while (num > 0)
    {
        num = num / 10;
        result++;
    }
    return result;
}

int number = Convert.ToInt32(Console.ReadLine());

int digit = thirdDigit(number);

if (digit == -1)
{
    Console.Write("Третьей цифры нет");
}
else
{
    Console.Write($"Третья цифра числа равна {digit}");
}
