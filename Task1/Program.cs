﻿// Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Input number A");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input number B");
int b = Convert.ToInt32(Console.ReadLine());
int step = a;

for(int i = 1; i < b; i++)
{
    step = step * a;
}
Console.WriteLine("А в степени В =  " + step);