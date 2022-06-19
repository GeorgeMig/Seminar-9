//Программа, которая выводит все натуральные числа в промежутке от N до 1 при помощи рекурсии;

Console.Write("Задайте число: ");
int n = int.Parse(Console.ReadLine());

void NaturalNumber(int num)
{
    if (num == 0) return;
    Console.Write($"{num}, ");
    NaturalNumber(num - 1);

}

NaturalNumber(n);