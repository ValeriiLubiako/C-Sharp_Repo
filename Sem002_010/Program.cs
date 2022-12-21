// Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1
//
using static MyLibrary;   //  ссылка на библиотеку
//
// используем написанный ранее метод 
// - DisplayReplyInt() - ввод целого числа с терминала
//  
//
int N;
string End = "Y";

while (End != "N")
{
    N = DisplayReplyInt("Введите целое число");

    if (N >= 100 && N <= 999)    // проверяем что ввели трехзначное число
    {

        int result = (N / 10) % 10;
        Console.WriteLine(result);
    }
    else
    {

        Console.WriteLine();

        Console.WriteLine("Ошибка ввода. Число должно быть трехзначным!!!");

    }
    Console.WriteLine();

    Console.WriteLine("Продолжить проверку чисел (Y/N");

    End = Console.ReadLine();
    if (End == "n") break;
    if (End == "т") break;
    if (End == "Т") break;
    if (End == "N") break;

}

