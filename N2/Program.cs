Console.Write("Введите число: ");
string a = Convert.ToString(Console.ReadLine());
int b = Convert.ToInt32(a);
if (a.Length > 2)
{
    for (int i = 0; (i < (a.Length) - 3); i++)
    {
        b = b / 10;
    }
    b = b % 10;
    Console.Write(b);
}
else
{
    Console.Write("Третьей цифры нет");
}