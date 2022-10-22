Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
switch (a)
{
    case <= 5:
        Console.Write("нет");
        break;
    case >= 8:
        Console.Write("введите число меньше 8");
        break;
    default:
        Console.Write("да");
        break;
}