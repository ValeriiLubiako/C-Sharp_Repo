﻿// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//
// 14212 -> нет
// 12821 -> да
// 23432 -> да
//
// СТРОКИ ИСПОЛЬЗОВАТЬ НЕЛЬЗЯ
//
using static MyLibrary;   //  ссылка на библиотеку
//
// - используем написанные ранее методы
// - DisplayReplyInt() - Метод ввода/вывода с терминала целого числа;
// - DisplayReplyString() - Метод ввода/вывода с терминала текстовой строки;
// - Inverse (number) - метод построения инвертированного числа (числа, полученного из исходного
//                  путем перстановки его цифр в обратном порядке).
//  
string End = "Y";


while (End != "N")
{


    int N = DisplayReplyInt("Введите целое число");

    if (Math.Abs(N) == Math.Abs(Inverse(N))) Console.WriteLine("Число " + $"{N,3}" + " является палиндромом");
    else Console.WriteLine("Число " + $"{N,3}" + " палиндромом не является");

    //     Console.WriteLine();
    // Console.WriteLine("Продолжить обработку (Y/N");
    // End = Console.ReadLine();

    End = DisplayReplyString("Продолжить обработку (Y/N");
    if (End == "n") break;
    if (End == "т") break;
    if (End == "Т") break;
    if (End == "N") break;
}