﻿// **Задача 39:** Напишите программу, которая перевернёт одномерный массив 
// (последний элемент будет на первом месте, а первый - на последнем и т.д.)

// [1 2 3 4 5] -> [5 4 3 2 1]

// [6 7 3 6] -> [6 3 7 6]

// Вариант 1
// static void MyArray()
// {
// int[] arr = { 1, 2, 3, 4, 5 };
// int n = arr.Length;

//     for (int i = 0; i < n / 2; i++)
//     {
//         int temp = arr[i];
//         arr[i] = arr[n - i - 1];
//         arr[n - i - 1] = temp;
//     }

//     foreach (int x in arr)
//     {
//         Console.Write($"{x} ");
//     }
// }
// MyArray();

// Вариант 2

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " ");
//     }
//     //System.Console.WriteLine();
// }

// int[] ReverseArray(int[] array)
// {   
//     int temp;
//     for (int i = 0; i < array.Length/2; i++)
//     {
//         temp = array[i];
//         array[i] = array[array.Length - 1 - i];
//         array[array.Length - 1 - i] = temp;
//     }
//     return array;
// }

// System.Console.Write("Input size: ");
// int size = Convert.ToInt32(Console.ReadLine());

// System.Console.Write("Input min value: ");
// int min = Convert.ToInt32(Console.ReadLine());

// System.Console.Write("Input max value: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, min, max);
// System.Console.Write("[");
// PrintArray(myArray);
// System.Console.Write("] -> [");
// myArray = ReverseArray(myArray);
// PrintArray(myArray);
// System.Console.Write("]");


// **Задача 42:** Напишите программу, которая будет преобразовывать десятичное число в двоичное.

// 45 -> 101101
// 3 -> 11
// 2 -> 10


// string DecimalToBinary(int num)
// {

//     string result = string.Empty;
//     while (num > 0)
//     {
//         result = num % 2 + result;
//         num /= 2;

//     }
//     return result;
// }

// System.Console.Write("Input num: ");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(DecimalToBinary(num));

// Задача 40: Напишите программу, которая принимает на вход три числа
// и проверяет, может ли существовать треугольник с сторонами такой длины.

// bool CheckTraingle(int a, int b, int c){
//     if (a + b > c && a + c > b && b + c > a){
//         System.Console.WriteLine("Такой треугольник существует!");
//         return true;
//     }else{
//         System.Console.WriteLine("Такой треугольник не существует!");
//         return false;
//     }
    
// }

// System.Console.Write("Input number 1: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Input number 2: ");
// int num2 = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Input number 3: ");
// int num3 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(CheckTraingle(num1, num2, num3));

// **Задача 44:** Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

// Если N = 5 -> 0 1 1 2 3

// Если N = 3 -> 0 1 1

// Если N = 7 -> 0 1 1 2 3 5 8

// int[] Fibonacci(int n){
//     int[] array = new int[n];
//     array[0] = 0;
//     array[1] = 1;

//     for (int i = 2; i < n; i++)
//     {
//         array[i] = array[n - 1] + array[i - 2];
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " ");
//     }
//     //System.Console.WriteLine();
// }

// System.Console.Write("Input number : ");
// int num = Convert.ToInt32(Console.ReadLine());
// PrintArray(Fibonacci(num));


