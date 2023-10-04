// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// int Extent(int a, int b){
//     int result = 1;
//     for (int i = 1; i <= b; i++)
//     {
//         result *= a;
//     }
//     return result;
// }

// System.Console.WriteLine($"3^5 -> {Extent(3,5)}");
// System.Console.WriteLine($"2^4 -> {Extent(2,4)}");


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// int GetSumDigits(int num)
// {
//   int result = 0;
//   while (Math.Abs(num) > 0)
//   {
//     result += num % 10;
//     num /= 10;
//   }

//   return result;
// }

// Console.WriteLine($"Sum of digits 452 = {GetSumDigits(452)}");
// Console.WriteLine($"Sum of digits 82 = {GetSumDigits(82)}");
// Console.WriteLine($"Sum of digits 9012 = {GetSumDigits(9012)}");

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

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
//     System.Console.WriteLine();
// }

// System.Console.Write("Input size: ");
// int size = Convert.ToInt32(Console.ReadLine());

// System.Console.Write("Input min: ");
// int min = Convert.ToInt32(Console.ReadLine());

// System.Console.Write("Input max: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, min, max);
// System.Console.Write("Your Array: ");
// PrintArray(myArray);


