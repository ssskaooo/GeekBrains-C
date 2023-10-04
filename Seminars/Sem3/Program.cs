// Напишите программу, которая принимает на вход координаты точки (X и Y),
//  причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.


// int FindQuarter(int x, int y)
// {
//     if (x > 0 && y > 0) return 1;
//     if (x < 0 && y > 0) return 2;
//     if (x < 0 && y < 0) return 3;
//     if (x > 0 && y < 0) return 4;
//     return 0;
// }


// System.Console.Write("Input X: ");
// int x = Convert.ToInt32(Console.ReadLine());
// System.Console.Write("Input Y: ");
// int y = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine(FindQuarter(x,y));

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

// System.Console.Write("Input n: ");
// int n = Convert.ToInt32(Console.ReadLine());
// QuadTable(n);


// void QuadTable(int n){
//     int current = 1;
//     System.Console.Write(n + " -> ");
//     while(current < n){
//         System.Console.Write(current * current + ", ");
//         current ++;
//     }
//     System.Console.WriteLine(current * current);
// }

// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

// System.Console.Write("Input quarter: ");
// int q = Convert.ToInt32(Console.ReadLine());
// Coord_quarter(q);


// void Coord_quarter(int quarter){
//     if(quarter == 1){
//         System.Console.WriteLine("X > 0 and Y > 0");
//     }else if(quarter == 2 ){
//         System.Console.WriteLine("X < 0 and Y > 0");
//     }else if(quarter == 3 ){
//         System.Console.WriteLine("X > 0 and Y < 0");
//     }else if(quarter == 4 ){
//         System.Console.WriteLine("X < 0 and Y < 0");
//     }else{
//         System.Console.WriteLine("Error");
//     }
// }



// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

// double Distance (double xa, double ya, double xb, double yb)
// {
//     return Math.Sqrt(Math.Pow(xb - xa, 2) + Math.Pow(yb - ya, 2));
// }

// System.Console.WriteLine("Напишите значения координат: ");
// System.Console.WriteLine("Координата Х точки А: ");
// double xa = Convert.ToDouble(Console.ReadLine());
// System.Console.WriteLine("Координата Y точки А: ");
// double ya = Convert.ToDouble(Console.ReadLine());
// System.Console.WriteLine("Координата Х точки B: ");
// double xb = Convert.ToDouble(Console.ReadLine());
// System.Console.WriteLine("Координата Y точки B: ");
// double yb = Convert.ToDouble(Console.ReadLine());

// System.Console.WriteLine($"A ({xa}, {ya}); B ({xb},{yb}) -> {Math.Round(Distance(xa, ya, xb, yb), 2)}");