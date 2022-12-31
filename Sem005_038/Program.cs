﻿// Задача 38. Задайте массив вещественных чисел. Найдите разницу между
// максимальным и минимальным элементов массива.
//
// [3 7 22 2 78] -> 76
//
using static MyLibrary;
//
// - используем написанные ранее методы
// - DisplayReplyInt() - Метод ввода/вывода с терминала целые числа;
// - CreateRealArray() - Метод инициализации массива вещественных чисет;
// - FillArray() - Метод заполнения массива случайными целыми числами из заданного диапазона значений;
// - PrintArrayInLine() - Метод вывода одномерного массива на печать в строки по N элементов,;
//                      но не больше,чем по 10 чисел в строке
// - DisplayReplyString() - Метод ввода с термина строки символов
//
string End = "Y";

int sBase = 15;

while (End != "N")
{

    int N = DisplayReplyInt("Введите целое число - число элементов массива");

    if (N < 1) Console.WriteLine("Число не может быть меньше 1");
    else
    {
        int[] MyArray = CreateIntArray(N);   // инициализация массива

        FillArray(MyArray, 100, 999);  //  заполнение массива целыми положительными трехзначными случайными числами

        Console.WriteLine("Распечатываем массив");
        PrintArrayInLine(MyArray, 10);     //  вывод массива на консоль не более 10 элементов в строку
        //
        // В цикле простым перебором подсчитываем количество четных чисел в массиве
        //
        int k = 0;
        int i = 1;

        while (i<N)
        {
            k = k + MyArray [i];
            i = i + 2;
        }

       
            Console.WriteLine(">>>>>>>---->>>>>>");
            Console.WriteLine();
            Console.WriteLine($"Сумма четных чисел в этом массиве равна: {k,2}");
           
    }
    End = DisplayReplyString("Продолжить обработку (Y/N");
    if (End == "n") break;
    if (End == "т") break;
    if (End == "Т") break;
    if (End == "N") break;
}