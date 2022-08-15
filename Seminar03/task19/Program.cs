// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число ");
int N = Convert.ToInt32(Console.ReadLine());

if (N >= 10000 && N < 100000)
{
    int a = N.ToString()[0] - '0';
    int b = N.ToString()[1] - '0';
    int c = N.ToString()[2] - '0';
    int d = N.ToString()[3] - '0';
    int f = N.ToString()[4] - '0';
    if (a  == b  && c  == d)
    {
        Console.WriteLine($"{N} является палиндромом");
    }
    else
    {
        Console.WriteLine($"{N} не является палиндромом");
    }
}
else
{
    Console.WriteLine("Введено некорректное число");
}
