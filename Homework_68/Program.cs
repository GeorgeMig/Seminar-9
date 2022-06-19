
Console.Write("Задайте число неотрицательное m = ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Задайте число неотрицательное n = ");
int num2 = int.Parse(Console.ReadLine());

int AckermanMethod(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if ((m > 0) && (n == 0))
    {
        return AckermanMethod(m - 1, 1);
    }
    else if ((m > 0) && (n > 0))
    {
        return AckermanMethod(m - 1, AckermanMethod(m, n - 1));
    }
    return 0;
}

int result = AckermanMethod(num1, num2);
Console.Write($"A({num1}, {num2}) => {result}");