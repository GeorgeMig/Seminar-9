// Программа, которая выводит все натуральные числа в промежутке от 1 до заданного числа (N)

Console.Write("Задайте число: ");
int n = int.Parse(Console.ReadLine());

void NaturalNumber(int num)
{
    if (num == 0) return;
    NaturalNumber(num - 1);
    Console.Write($"{num} ");
}

NaturalNumber(n);