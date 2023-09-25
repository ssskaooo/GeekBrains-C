using System;

// Внутри класса Answer напишите метод IsPalindrome, который принимает на вход 
// пятизначное число number и проверяет, является ли оно палиндромом.
// Метод должен проверить является ли число пятизначным, в противном случае - вывести 
// Число не пятизначное и False в следующей строке.
// Для остальных чисел вернуть True или False.

public class Answer
{
    static bool IsPalindrome(int number){
        if (number < 9999 || number > 99999)
        {
            Console.WriteLine("Число не пятизначное");
            return false;
        }
        string numberString = number.ToString();
        for (int i = 0; i < numberString.Length; i++)
        {
            if (numberString[i] != numberString[numberString.Length - 1 - i])
            {
                return false;
            }
        }
        return true;
      
    }
  
  // Не удаляйте и не меняйте метод Main! 
      static public void Main(string[] args) {
        int number;

        if (args.Length >= 1) {
            number = int.Parse(args[0]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
            number = 234322;
        }

        // Не удаляйте строки ниже
        bool result = IsPalindrome(number);
        System.Console.WriteLine($"{result}");
    }
}
