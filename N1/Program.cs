Console.Write("Введите трехзначное число: ");
int secondNumber(int a)
{
    a = a % 100;
    a = a / 10;
    return a;
}
int number = Convert.ToInt32(Console.ReadLine());
int sec = secondNumber(number);
Console.Write($"Вторая цифра числа это {sec}");