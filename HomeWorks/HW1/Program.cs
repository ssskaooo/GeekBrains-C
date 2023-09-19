// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
// какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Решение
// System.Console.WriteLine("Inpute number 1: ");
// int a = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Inpute number 2: ");
// int b = Convert.ToInt32(Console.ReadLine());
// if(a > b){
//     System.Console.WriteLine("max a = " + a + " min b = " + b);
// }
// else{
//     System.Console.WriteLine("max b = " + b + " min a = " + a);
// }


// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Решение
// System.Console.WriteLine("Inpute number 1: ");
// int a = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Inpute number 2: ");
// int b = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Inpute number 2: ");
// int c = Convert.ToInt32(Console.ReadLine());
// int max;

// if(a > b && a > c){
//     System.Console.WriteLine("max a = " + a);
// }
// else if(b > c && b > a){
//     System.Console.WriteLine("max b = " + b);
// }
// else if(c > b && c > a){
//     System.Console.WriteLine("max c = " + c);
// }

// Задача 6: Напишите программу, которая на вход принимает 
// число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

// Решение
// System.Console.WriteLine("Inpute number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// if(number %2 == 0){
//     System.Console.WriteLine($"Число {number} -> Четное");
// }
// else{
//     System.Console.WriteLine($"Число {number} -> Не четное");
// }
    

// Задача 8: Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

// Решение
// System.Console.WriteLine("Inpute number: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int i;
// for(i=1;i<=n;i++){
//     if(i %2 == 0)
//     System.Console.Write(i + " ");
// }