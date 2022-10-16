// Задайте значения M и N. Напишите программу, которая 
//найдёт сумму натуральных элементов в промежутке от M до N.

Console.WriteLine("Введите число M");
int numM = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число N");
int numN = int.Parse(Console.ReadLine()!);


void ShowNumsBetween(int min, int max)
{

    if (min == max)
    {
        Console.Write(min);
        return;
    }
    if (min > max)
    {
        Console.Write($"{min} ");
        ShowNumsBetween(min - 1, max);
    }
    else
    {
        Console.Write($"{max} ");
        ShowNumsBetween(min, max - 1);
    }
}

ShowNumsBetween(numM, numN);
Console.WriteLine();

SumArray(numM, numN);


void SumArray(int numM, int numN)
{
    if (numM == numN)
    {
        Console.Write(numM);
        return;
    }
    if (numM < numN)
    {
        int sum = 0;

        for (int i = 0; i <= numN - numM; i++)
        {
            sum = numM + i + sum;

        }
        Console.WriteLine($"Сумма элементов от М до N равна = {sum}");
    }
    else
    {
        int sum = 0;
        for (int i = 0; i <= numM - numN; i++)
        {
            sum = numM - i + sum;

        }
        Console.WriteLine($"Сумма элементов от М до N равна = {sum}");
    }
}