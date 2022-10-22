Console.Write("Введите трехзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
a = a % 100;
a = a / 10;
Console.WriteLine(a);