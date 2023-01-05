// Задайте значения M и N. 
// Напишите программу, которая выведет 
// все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

void EvenNumbers(int m, int n)
{
    if (m > n)
    {
        return;
    }
    else if (m % 2 == 0)
    {
        System.Console.Write($"{m}; ");
        EvenNumbers(m + 2, n);
    }
    else if (m % 2 != 0)
    {
        m = m + 1;
        System.Console.Write($"{m}; ");
        EvenNumbers(m + 2, n);
    }
}

EvenNumbers(1, 5);
System.Console.WriteLine();
EvenNumbers(4, 8);
System.Console.WriteLine();
EvenNumbers(5, 38);