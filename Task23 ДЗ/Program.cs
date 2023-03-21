﻿// Задача 23: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27. 64, 125

Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

CubeSquare(number);

void CubeSquare(int num)
{
    int count = 1;
    while (count <= num)
    {
    Console.WriteLine($" {count, 3} {Math.Pow(count, 3), 5} ");
    count ++;
    }
}