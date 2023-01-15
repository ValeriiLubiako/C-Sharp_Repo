// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить сомощью рекурсии.
//
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
//
using static MyLibrary;
//
Console.WriteLine(">>>>>------>>>>>" + '\n');
int k = 5;
Console.WriteLine("N = 5 -> " + NatRecurse(k));
Console.WriteLine(">>>>>------>>>>>" + '\n');
k = 8;
Console.WriteLine("N = 8 -> " + NatRecurse(k));
