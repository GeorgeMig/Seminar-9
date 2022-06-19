// Программа, которая возводит число a в степень равную b при помощи рекурсии

Console.Write("Задайте число m = ");
int a = int.Parse(Console.ReadLine());
Console.Write("Задайте число n = ");
int b = int.Parse(Console.ReadLine());
int res = 1;


void FinddegreeNumber(int number, int degree, int result) // метод, возводящий число а в степень равную b при помощи рекурсии
{
    if (degree == 0) 
    {
        Console.Write($"Введенное число в заданной степени равняется {result}");
        return;
    }
    result = result * number;
    degree--;
    FinddegreeNumber(number, degree, result);
}

FinddegreeNumber(a, b, res); // выполнение метода
