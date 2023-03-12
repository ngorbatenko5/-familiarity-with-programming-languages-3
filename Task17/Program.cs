﻿// 17. Напишите программу, которая 
// 1 принимает на вход координаты точки (X и Y),
// 2 причём X ≠ 0 и Y ≠ 0
// 3 и выдаёт номер четверти плоскости, в которой находится эта точка.

Console.WriteLine("Введите кординаты точки");
Console.WriteLine("X: ");
int xCoordinate = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Y: ");
int yCoordinate = Convert.ToInt32(Console.ReadLine());

int quarter = Quarter(xCoordinate, yCoordinate);
string result = quarter > 0
                ? $"Указанные координаты соответствуют четверти -> {quarter}"
                : "Введены некоректные координаты";
Console.WriteLine(result);

int Quarter (int x, int y)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;
    return 0;
}

