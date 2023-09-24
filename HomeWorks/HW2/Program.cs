
// Задача 10: Напишите программу, которая принимает на вход трёхзначное 
// число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

// Решение

// void secondDigitalOfThree(int num){
//     int ed = (num % 10) / 10;
//     System.Console.WriteLine($"Второе число из трех -> {num}");
// }

// int num1 = new Random().Next(100, 1000);
// secondDigitalOfThree(num1);


// Задача 13: Напишите программу, которая выводит третью цифру
//  заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Решение



// void checkNumber(int num){
// while(num > 999){
//     num /= 10;
// }
// if(num >= 100 && num < 1000){
//     int ed = num % 10;
//     System.Console.WriteLine($"Третья цифра из числа {num} -> {ed}");
// }
// else{
//     System.Console.WriteLine($"Третьей цифры из числа {num} -> нет");
// }
// }

// System.Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// checkNumber(num);



// Задача 15: Напишите программу, которая принимает на вход цифру,
//  обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

// Решение

// System.Console.WriteLine("Введите цифру, обозначающую день недели: ");
// int num = Convert.ToInt32(Console.ReadLine());
// checkDayOfWeek(num);

// void checkDayOfWeek(int num)
// {

//     if (num >= 1 && num <= 5)
//     {
//         System.Console.WriteLine($"Данный день является рабочим");
//     }
//     else if (num == 6 || num == 7)
//     {
//         System.Console.WriteLine("Данный день явлеется выходным");
//     }
//     else
//     {
//         System.Console.WriteLine("Вы ввели цифру не соответствующую дням недели!");
//     }
// }

