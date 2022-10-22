Console.Write("Введите число: ");
int dayCheck(int a)
{
    switch (a)
    {
        case <= 5:
            Console.Write("нет");
            return 0;
        case >= 8:
            Console.Write("введите число меньше 8");
            return 0;
        default:
            Console.Write("да");
            return 0;
    }
}
int a = Convert.ToInt32(Console.ReadLine());
dayCheck(a);