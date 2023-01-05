// Задайте значения M и N. 
// Напишите программу, 
// которая найдёт сумму натуральных элементов 
// в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int SumNumbers(int number1, int number2)
{
    if (number1 == number2)
    {
        return number1;
    }
    return number1 + SumNumbers(number1 + 1, number2);
}

System.Console.WriteLine(SumNumbers(1,15));
System.Console.WriteLine(SumNumbers(4,8));