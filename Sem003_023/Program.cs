// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N..
//
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
//
//
using static MyLibrary;
//
// - используем написанные ранее методы
// - DisplayReplyDouble() - Метод ввода/вывода с терминала числа типа double;
// - DisplayReplyString() - Метод ввода/вывода с терминала текстовой строки;
// - PrintArrayInLine() - Метод вывода одномерного массива на печать в строки по N элементов, 
//                      но не больше,чем по 10 чисел в строке
//
//
string End = "Y";

while (End != "N")
{

    int N = DisplayReplyInt("Введите целое число");

    if (N < 1)
    {
        Console.WriteLine("Число не может быть меньше 1");
    }
    else
    {
        int[] Array = CreateIntArray(N);   // инициализация массива для кубов чисел от 1 до N

        for (int i = 1; i <= N; i++) Array[i - 1] = i * i * i;   //  занесение кубов в массив

        PrintArrayInLine(Array, 10);

        End = DisplayReplyString("Продолжить обработку (Y/N");
        if (End == "n") break;
        if (End == "т") break;
        if (End == "Т") break;
        if (End == "N") break;
    }
}