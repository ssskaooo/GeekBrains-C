//Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в
//промежутке от N до 1. Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

//void PrintN(int n)
//{
//    if (n > 0)
//    {
//        System.Console.Write($"{n} ");
//        PrintN(n - 1);
//    }
//}

//PrintN(10);



//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных
//элементов в промежутке от M до N.Выполнить с помощью рекурсии.
//M = 1; N = 15-> 120
//M = 4; N = 8. -> 30

//using System;

//int GetSumRange(int m, int n)
//{
//    int min = m > n ? n : m;
//    int max = m > n ? m : n;
//    if (min < max)
//    {
//        return GetSumRange(min, max - 1) + max;
//    }
//    else if (min == max)
//        return min;
//    else
//        return 0;
//}

//int m = 1;
//int n = 5;
//System.Console.WriteLine($"sum({m};{n}) = {GetSumRange(m, n)}");
//m = 5;
//n = 1;
//System.Console.WriteLine($"sum({m};{n}) = {GetSumRange(m, n)}");





//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два
//неотрицательных числа m и n.Выполнить с помощью рекурсии.
//m = 2, n = 3->A(m, n) = 9
//m = 3, n = 2->A(m, n) = 29




int AkkermanFunction(int n, int m)
{
    if (n == 0)
        return m + 1;
    else if (m == 0)
        return AkkermanFunction(n - 1, 1);
    else
        return AkkermanFunction(n - 1, AkkermanFunction(n, m - 1));
}

int n = 2;
int m = 3;
System.Console.WriteLine($"Ackerman({n},{m})= {AkkermanFunction(n, m)}");
n = 3;
m = 2;
System.Console.WriteLine($"Ackerman({n},{m})= {AkkermanFunction(n, m)}");




