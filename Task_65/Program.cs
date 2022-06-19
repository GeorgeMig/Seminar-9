// Программа, которая выводит все натуральные числа в заданном промежутке. 

Console.Write("Задайте число m = ");
int m = int.Parse(Console.ReadLine());
Console.Write("Задайте число n = ");
int n = int.Parse(Console.ReadLine());



void NaturalNumber(int start, int end) // метод вывода чисел расположенных в заданном в диапозоне.
{
    if (start < end)
    {
        if (end == start - 1) return;
        NaturalNumber(start, end - 1);
        Console.Write($"{end} ");
    }
    else
    {
        if (start - 1 == end) return;
        NaturalNumber(end, start - 1);
        Console.Write($"{start} ");
    }
}

NaturalNumber(m, n); // выполнение метода