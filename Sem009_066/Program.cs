﻿// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
//
using static MyLibrary;
//
Console.WriteLine(">>>>>------>>>>>" + '\n');
int M = 1;
int N = 15;
Console.WriteLine("Cумма натуральных чисел в промежутке от " + $"{M}" + " до " + $"{N}" + " равна " + $"{NatSumFromTo(M,N)}" + ".");
Console.WriteLine(">>>>>------>>>>>" + '\n');
M = 4;
N = 8;
Console.WriteLine("Cумма натуральных чисел в промежутке от " + $"{M}" + " до " + $"{N}" + " равна " + $"{NatSumFromTo(M,N)}" + ".");