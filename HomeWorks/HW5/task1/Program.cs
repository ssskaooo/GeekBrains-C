using System;

public class Answer
{
    public static int CountEvenElements(int[] array)
    {
        // Введите свое решение ниже
        int evenCount = 0;
        foreach (var number in array)
        {
            if (number % 2 == 0 && number >= 100 && number <= 999)
            {
                evenCount++;
            }
        }
        return evenCount;


    }

    public static void PrintArray(int[] array)
    {
        // Введите свое решение ниже
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
        // System.Console.Wrtite($“{array[i]}\t”);

    }


    // Не удаляйте и не меняйте метод Main! 
    public static void Main(string[] args)
    {
        int[] array;
        if (args.Length == 0)
        {
            // Здесь вы можете поменять значения для отправки кода на Выполнение
            array = new int[] { 124, 378, 593, 821, 456 };
        }
        else
        {
            string[] argStrings = args[0].Split(", ");
            array = new int[argStrings.Length];
            for (int i = 0; i < argStrings.Length; i++)
            {
                if (int.TryParse(argStrings[i], out int number))
                {
                    array[i] = number;
                }
                else
                {
                    Console.WriteLine($"Ошибка при парсинге аргумента {argStrings[i]}.");
                    return;
                }
            }
        }

        // Не удаляйте строки ниже
        Console.WriteLine("Массив:");
        PrintArray(array);
        int evenCount = CountEvenElements(array);
        Console.WriteLine($"Количество четных элементов: {evenCount}");
    }
}
