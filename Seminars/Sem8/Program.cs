﻿/*
 Задание 1. Задайте двумерный массив. Напишите программу, которая поменяет местами
 первую и последнюю строку массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
8 4 2 4
5 9 2 3
1 4 7 2
*/


int[,] Create2DArray(int rows, int columns)
{
    return new int[rows, columns];
}

void Fill2DArray(int[,] array, int minValue, int maxValue)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(minValue, maxValue);
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write($"{array[i, j]}" + " ");
        Console.WriteLine();
    }
    System.Console.WriteLine();
}

void ChangeRows(int[,] array, int row1, int row2)
{
    if (row1 > array.GetLength(0) || row2 > array.GetLength(0) || row1 < 0 || row2 < 0)
    {
        System.Console.WriteLine("Index of row is out of bound!");
    }
    else
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int temp = array[row1, j];
            array[row1, j] = array[row2, j];
            array[row2, j] = temp;
        }
    }
}

void RowsToColumns(int[,] array)
{
    if (array.GetLength(0) != array.GetLength(1)) System.Console.WriteLine("Invalid array!");
    else
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = i + 1; j < array.GetLength(0); j++)
            {
                int temp = array[i, j];
                array[i, j] = array[j, i];
                array[j, i] = temp;
            }
        }
    }

int[,] DeleteRowAndColumnWithMin(int[,] array)
    {
        int min = array[0, 0];
        int minPositionI = 0;
        int minPositionJ = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] < min)
                {
                    min = array[i, j];
                    minPositionI = i;
                    minPositionJ = j;
                }
            }
        }

        for (int i = 0; i < array.GetLength(0); i++)
        {
            array[i, minPositionJ] = 0;
        }

        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[minPositionI, j] = 0;
        }

        return array;
    }

    System.Console.Write("Input num of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Input num of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Input min value: ");
int minValue = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Input max value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());


System.Console.Write("Input num of first row: ");
int row1 = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Input num of second row: ");
int row2 = Convert.ToInt32(Console.ReadLine());

int[,] myArray = Create2DArray(rows, columns);
Fill2DArray(myArray, minValue, maxValue);
Print2DArray(myArray);
ChangeRows(myArray, row1, row2);
Print2DArray(myArray);


/*
Задание 2. Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
В случае, если это невозможно, программа должна вывести сообщение для пользователя.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
В итоге получается вот такой массив:
1 5 8 5
4 9 4 2
7 2 2 6
2 3 4 7
*/

