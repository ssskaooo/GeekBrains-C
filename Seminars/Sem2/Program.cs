// Напишите программу, которая будет принимать на вход два числа и выводить,
// является ли второе число кратным первому. Если второе число не кратно числу первому,
// то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4
// 16, 4  -> кратно

// Решение
// void CHeckMultiplicity(int num1, int num2)
// {
//     if (num1 % num2 == 0)
//     {
//         System.Console.WriteLine($"{num1}, {num2} -> кратно");
//     }
//     else
//     {
//         System.Console.WriteLine($"{num1}, {num2} -> не кратно, остаток {num1 & num2}");
//     }
// }

// System.Console.WriteLine("Введите два числа ");
// System.Console.WriteLine("Введите первое число:  ");
// int n1 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите первое число:  ");
// int n2 = Convert.ToInt32(Console.ReadLine());

// CHeckMultiplicity(n1, n2);


// Напишите программу, которая выводит случайное число
//  из отрезка [10, 99] и показывает наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

// Решение
// int BiggestDigit(int num)
// {
//     int ed = num % 10;
//     int dec = num / 10;
//     if(ed > dec){
//         return ed;
//     }
//     else{
//         return dec;
//     }
// }

// int num = new Random().Next(10, 100);
// System.Console.WriteLine(num);
// // int result = BiggestDigit(num);
// System.Console.WriteLine(BiggestDigit(num));

// Напишите программу, которая выводит случайное трёхзначное число
//  и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98
// Решение

void exampleMethod(int num){
    int hund = num / 100;
    int ed = num % 10;
    System.Console.WriteLine($"{num} -> {hund * 10 + ed}");
}

int num = new Random().Next(100, 1000);
exampleMethod(num);

// Напишите программу, которая принимает на вход число и проверяет, 
// кратно ли оно одновременно 7 и 23.
// 14  ->  нет
// 46  ->  нет
// 161 ->  да

// Решение

// bool multiplicityOfNumbers(int num){
//     if(num % 7 == 0 && num % 23 == 0 ){
//         System.Console.WriteLine("numbers multiplicity");
//         return true;
//     }
//     else{
//         System.Console.WriteLine("numbers not multiplicity");
//         return false;

//     }
// }

// System.Console.WriteLine("Введите число:  ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($"Число {num1} -> {multiplicityOfNumbers(num1)}");
