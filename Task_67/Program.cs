// Программа, которая принимает на вход число и возвращает сумму его цифр

Console.Write("Задайте число n = ");
int n = int.Parse(Console.ReadLine());
int sum = 0;

void SumNumber(int count, int summ) // метод нахождения суммы цифр в заданном числе при помощи рекурсии
{
    if (count == 0) 
    {
        Console.Write($"Сумма цифр в числе {n} равна {summ}"); 
        return;
    }
    int number = count % 10;
    count /= 10;
    summ += number;
    SumNumber(count, summ);

}


SumNumber(n, sum); // выполнение метода
