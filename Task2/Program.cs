﻿// Напишите программу, которая принимает на вход число и 
// выдаёт сумму цифр в числе.

// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Input number");
int i = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while (i > 0)
{
    int number = i % 10;
    i = i / 10;
    sum = sum + number;
}
Console.WriteLine("The sum of all numbers is  " + sum);