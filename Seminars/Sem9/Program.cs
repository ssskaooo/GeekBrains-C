//Задача 1. Задайте значение N. Напишите программу, которая выведет все натуральные 
//    числа в промежутке от 1 до N.
//N = 5 -> "1, 2, 3, 4, 5"
//N = 6-> "1, 2, 3, 4, 5, 6"


//void ShowNums(int n) 
//{ 
//    if(n > 0)
//    {
//        ShowNums(n - 1);
//        Console.Write(n + " ");
//    }
//}
//ShowNums(10);


//Задание 2. Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
//453 -> 12
//45 -> 9

//int FindSum(int num)
//{
//    if(num > 0) return  FindSum(num / 10) + num % 10;
//    else return num;

//}

//Console.WriteLine(FindSum(453)); 

//Задача 3. Задайте значения M и N. Напишите программу, которая выведет все
//натуральные числа в промежутке от M до N.
//M = 1; N = 5. -> "1, 2, 3, 4, 5"
//M = 4; N = 8. -> "4, 5, 6, 7, 8"

//using System;

//class Program
//{
//    static void Main()
//    {
//        Console.Write("Введите значение M: ");
//        int m = int.Parse(Console.ReadLine());

//        Console.Write("Введите значение N: ");
//        int n = int.Parse(Console.ReadLine());

//        Console.WriteLine("Натуральные числа в промежутке от M до N: ");
//        PrintNumbers(m, n);
//    }

//    static void PrintNumbers(int m, int n)
//    {
//        if (m <= n)
//        {
//            Console.WriteLine(m);
//            PrintNumbers(m + 1, n);
//        }
//    }
//}



//Задача 4.Напишите программу, которая на вход принимает два числа A и B, и
//возводит число А в целую степень B с помощью рекурсии.
//A = 3; B = 5 -> 243 (3⁵)
//A = 2; B = 3 -> 8


//class Program
//{
//    static void Main()
//    {
//        Console.Write("Введите число A: ");
//        int a = Convert.ToInt32(Console.ReadLine());

//        Console.Write("Введите степень B: ");
//        int b = Convert.ToInt32(Console.ReadLine());

//        int result = Power(a, b);
//        Console.WriteLine("Результат: " + result);
//    }

//    static int Power(int a, int b)
//    {
//        if (b == 0)
//        {
//            return 1;
//        }
//        else
//        {
//            return a * Power(a, b - 1);
//        }
//    }
//}