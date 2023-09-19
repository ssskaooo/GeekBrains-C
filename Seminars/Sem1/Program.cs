// System.Console.WriteLine("Inpute number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($"Your number  -> {num}");

// Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).

// System.Console.Write("Inpute number: ");
// int num = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine($"Quad of {num} -> {num * num}");


// Задача:  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает 
// **последнюю** цифру этого числа.
    // 456 -> 6
    // 782 -> 2
    // 918 -> 8

// System.Console.Write("Inpute three-digit number: ");
// int num = Convert.ToInt32(Console.ReadLine());

// if(num >= 100 && num < 1000){
//     System.Console.WriteLine($"Last digit of {num} -> {num%10}");
// }
// else{
//     System.Console.WriteLine("You input not three-digit number");
// }

// Задача: Напишите программу, которая на вход принимает одно число (N), 
// а на выходе показывает все целые числа в промежутке от -N до N.

// 4 -> "-4, -3, -2, -1, 0, 1, 2, 3, 4"
// 2 -> " -2, -1, 0, 1, 2"

// System.Console.WriteLine("Inpute number: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int count = -n;
// while(count <= n){
//     System.Console.Write(count++ + " ");
// }
    

// Задача: Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.

// a = 25; b = 5 -> да
// a = 2 b = 10 -> нет
// a = 9; b = -3 -> да
// a = -3 b = 9 -> нет

// System.Console.WriteLine("Inpute number 1: ");
// int n1 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Inpute number 2: ");
// int n2 = Convert.ToInt32(Console.ReadLine());
// if(n1 == n2*n2){
//     System.Console.WriteLine($"{n1} is quad {n2}");
// }
// else{
//     System.Console.WriteLine($"{n1} not quad {n2}");
// }