// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

// Console.WriteLine("Введите кординаты первой точки");
// Console.WriteLine("X: ");
// int xA = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Y: ");
// int yA = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите кординаты второй точки");
// Console.WriteLine("X: ");
// int xB = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Y: ");
// int yB = Convert.ToInt32(Console.ReadLine());

// double result = Math.Round (Distance(xA, yA, xB, yB), 2, MidpointRounding.ToZero);

// Console.WriteLine($"Это квадрат числа {result}");

// double Distance(int x1, int y1, int x2, int y2)   
// {
//     return Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2));
// }

// double sqrt = Math.Sqrt(5);
// double d = 5.099876453;
// double sqrtRound = Math.Round(d, 2, MidpointRounding.ToZero); Math
// Console.WriteLine(d + "\n" + sqrtRound); 

Console.WriteLine("Введите кординаты первой точки");
Console.WriteLine("X: ");
int xA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Y: ");
int yA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("W: ");
int wA = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите кординаты второй точки");
Console.WriteLine("X: ");
int xB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Y: ");
int yB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("W: ");
int wB = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите кординаты третьей точки");
Console.WriteLine("X: ");
int xC = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Y: ");
int yC = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("W: ");
int wC = Convert.ToInt32(Console.ReadLine());

double result = Math.Round (Distance(xA, yA, wA, xB, yB, wB, xC, yC, wC), 2, MidpointRounding.ToZero);

Console.WriteLine($"Это пространство числа {result}");

double Distance(int x1, int y1, int x2, int y2, int x3, int y3)   
{
    return Math.Sqrt((x1 - x2 - x3) * (x1 - x2 - x3) + (y1 - y2 - y3) * (y1 - y2 - y3));
}