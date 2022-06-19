// Программа, которая находит сумму натуральных чисел в заданном промежутке. 

Console.Write("Задайте число начало= ");
int m = int.Parse(Console.ReadLine());
Console.Write("Задайте число конец = ");
int n = int.Parse(Console.ReadLine());
int summer = 0;




void SumNaturalNumber(int start, int end, int sum) // метод подсчета суммы натуральных чисел в заданном промежутке.
{
    if (start <= end)
    {
        sum += start;
        start++;
        NaturalNumber(start, end, sum);
    }
    else
    {
        Console.Write(sum);
    }


}

SumNaturalNumber(m, n, summer); // выполнение метода