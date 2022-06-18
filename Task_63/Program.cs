// Программа, которая выводит все натуральные числа в промежутке от 1 до заданного числа (N)

Console.Write("Задайте число: ");
int n = int.Parse(Console.ReadLine());

void NaturalNumber(int num)
{
    if (num == 1) return;
    num--;
    NaturalNumber(num);
    Console.Write($"{num} ");
}

NaturalNumber(n + 1);