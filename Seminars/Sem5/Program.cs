//Задача 1. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму отрицательных и положительных элементов массива.

//Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.


//int[] CreateRandomArray(int size, int minValue, int maxValue)
//{
//int[] array = new int[size];
//for(int i = 0; i < size; i++)
//{
//array[i] = new Random().Next(minValue, maxValue + 1);
//}
//return array;
//}

//void PrintArray(int[] array)
//{
//for(int i = 0; i < array.Length; i++)
//{
// System.Console.Write(array[i] + " ");
// }
//}


//void PosNegSum(int [] array)
//{
//  int positiveSum = 0;
//int negativeSum = 0;
//for(int i = 0; i < array.Length; i++)
//{
// if(array[i] > 0)
//{
//  positiveSum += array[i];
//}
//else
//{
//negativeSum += array[i];
//}
//}
//System.Console.WriteLine(($"sum of positive array -> {positiveSum}\n{negativeSum}"));
//}



//System.Console.Write("Input size: ");
//int size = Convert.ToInt32(Console.ReadLine());
//
//System.Console.Write("Input min: ");
//int min = Convert.ToInt32(Console.ReadLine());

//System.Console.Write("Input max: ");
//int max = Convert.ToInt32(Console.ReadLine());

//int[] myArray = CreateRandomArray(size, min, max);

//PrintArray(myArray);

//PosNegSum(myArray);


//Задача 35:** 
//Задайте одномерный массив из 123 случайных чисел. 
//Найдите количество элементов массива, 
//значения которых лежат в отрезке [10,99].

//*Пример для массива из 5, 
//а не 123 элементов. /
//В своём решении сделайте для 123*

//[5, 18, 123, 6, 2] -> 1

// int[] CreateRandomArray(int size, int minValue, int maxValue)
// {
//     int[] array = new int[size];
//     for(int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue + 1);
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++)
//     {
//         System.Console.Write(array[i] + " ");
//     }
// }

// int ElementsCounter(int[] array, int min, int max)
// {
//     int count = 0;
//     for(int i = 0; i < array.Length; i++)
//     {
//         if(array[i] >= min && array[i] <= max)
//         {
//             count++;
//         }
//     }
//     return count;
// }

// System.Console.Write("Input size: ");
// int size = Convert.ToInt32(Console.ReadLine());

// System.Console.Write("Input minV: ");
// int minValue = Convert.ToInt32(Console.ReadLine());

// System.Console.Write("Input maxV: ");
// int maxValue = Convert.ToInt32(Console.ReadLine());

// System.Console.Write("Input lover bound: ");
// int min = Convert.ToInt32(Console.ReadLine());

// System.Console.Write("Input upper bound: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, minValue, maxValue);
// PrintArray(myArray);
// System.Console.WriteLine(ElementsCounter(myArray, min, max));


//**Задача 33:** Задайте массив. 
//Напишите программу, которая определяет, присутствует ли заданное число в массиве.

//4; массив [6, 7, 19, 345, 3] -> нет
//3; массив [6, 7, 19, 345, 3] -> да

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
// }

// bool FindElemen(int[] array, int n)
// {
//     for (int i = 0; i <= array.Length; i++)
//     {
//         if (n == array[i])
//         {
//             return true;
//         }

//     }
//     return false;
// }

// System.Console.Write("Input size: ");
// int size = Convert.ToInt32(Console.ReadLine());

// System.Console.Write("Input min: ");
// int min = Convert.ToInt32(Console.ReadLine());

// System.Console.Write("Input max: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myArray = CreateRandomArray(size, min, max);
// PrintArray(myArray);
// System.Console.WriteLine();

// System.Console.WriteLine("Input N: ");
// int n = Convert.ToInt32(Console.ReadLine());

// System.Console.WriteLine(FindElemen(myArray, n));







//**Задача 32:** Напишите программу замена элементов массива: 
//положительные элементы замените на соответствующие отрицательные, и наоборот.

//[-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
    }
    System.Console.WriteLine();
}

int[] Nothhing(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = array[i] * -1;
    }
    return array;
}

System.Console.Write("Input size: ");
int size = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Input min: ");
int min = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Input max: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);
System.Console.Write("Your Array: ");
PrintArray(myArray);

int[] NothArr = Nothhing(myArray);
System.Console.Write("My Array: ");
PrintArray(NothArr);
