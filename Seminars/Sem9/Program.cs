//Задача 1. Задайте значение N. Напишите программу, которая выведет все натуральные 
//    числа в промежутке от 1 до N.
//N = 5 -> "1, 2, 3, 4, 5"
//N = 6-> "1, 2, 3, 4, 5, 6"


void ShowNums(int n) 
{
    if (n > 0)
    {
        ShowNums(n - 1);
        Console.Write(n + " ");
    }
}
ShowNums(10);


//Задание 2. Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
//453 -> 12
//45 -> 9

int FindSum(int num)
{
    if (num > 0) return FindSum(num / 10) + num % 10;
    else return num;

}

Console.WriteLine(FindSum(453));

//Задача 3. Задайте значения M и N. Напишите программу, которая выведет все
//натуральные числа в промежутке от M до N.
//M = 1; N = 5. -> "1, 2, 3, 4, 5"
//M = 4; N = 8. -> "4, 5, 6, 7, 8"

void PrintRange(int m, int n)
{
    int min = m > n ? n : m;
    int max = m > n ? m : n;
    if (min < max)
    {
        PrintRange(min, max - 1);
        System.Console.Write($"{max} ");
    }
    else if (min == max)
        System.Console.Write($"{min} ");
}

PrintRange(23, 1);



//Задача 4.Напишите программу, которая на вход принимает два числа A и B, и
//возводит число А в целую степень B с помощью рекурсии.
//A = 3; B = 5-> 243(3⁵)
//A = 2; B = 3-> 8


int GetPower(int base_, int exponent)
{
    if (exponent == 1)
        return base_;
    return GetPower(base_, exponent - 1) * base_;
}

int base_ = 3;
int exponent = 3;
System.Console.WriteLine($"{base_}^{exponent} = {GetPower(base_, exponent)}");