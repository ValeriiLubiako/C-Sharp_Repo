// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки
// двумерного массива.
// Например, задан массив:
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
//
using static MyLibrary;
//
// - используем написанные ранее методы
// - DisplayReplyInt() - Метод ввода/вывода с терминала целые числа;
// - CreateRealArrayTwoDim() - Метод инициализации двумерного массива вещественных чисет;
// - CreateRealArray() - Метод инициализации массива вещественных чисет;
// - FillArrayConsoleDouble(() - Метод заполнения массива вещественными числами с консоли;
// - PrintRealArrayTwoDim() - Метод вывода содержимого массива на консоль с печатью заголовка (текстовой строки);
// - DisplayReplyIntSaveConsole() -  Метод ввода с терминала целого числа (без предварительно очищения консоли);
// - PrintRealArrwithHeader() - Метод вывода на печать одномерного массива вещественных чисел с печатью заголовка;
// - DisplayReplyString() - Метод ввода с терминала строки символов;
// - BubbleSortbyRowTwoDimDesc() - 
// - HappyNewYear() - Метод вывода на консоль сообщения (прогрессирующая текстовая строка, 
//                  с буквами разных цветов, подобранных по определенной  гамме)
//
string End = "Y";
int nPos = 0;   // номер позиции интересующего элемента в массиве

while (End != "N")
{

    int N = DisplayReplyInt("Введите целое число - число строк массива");

    if (N < 1)
    {
        if (nPos == -777) break;
        Console.WriteLine("Число не может быть меньше 1");
    }
    else
    {
        int M = 0;
        if (M == 777) break;
        while (End != "N")
        {
            if (nPos == -777) break;
            // Console.WriteLine();
            M = DisplayReplyIntSaveConsole('\n' + "Введите целое число - число столбцов массива (выход -777)");

            if (M < 1)
            {
                if (M == -777) break;
                Console.WriteLine("Число не может быть меньше 1");
            }
            else
            {

                double[,] MyArray = CreateRealArrayTwoDim(N, M);   // инициализация массива
                                                                   // далее будем вести обработку через одномерный массив, чтобы воспользоваться разработанным 
                                                                   // ранее инструментарием для одномерных массивов

                int dArrayLength = N * M;

                double[] dArray = CreateRealArray(dArrayLength);

                // Введем с консоли элементы двумерного массива (по строкам и столбцам), помещая их в одномерный массив

                if (FillArrayConsoleDouble(dArray, false))
                {
                    for (int i = 0; i < N; i++)
                    {
                        for (int j = 0; j < M; j++) MyArray[i, j] = dArray[i * M + j];
                    }

                    // Bubble_Sort(dArray);


                    Console.Clear();
                    Console.WriteLine('\n' + ">>>>>>>---->>>>>>");
                    PrintRealArrwithHeader("Распечатываем введенный одномерный массив построчно", dArray, M);
                    Console.WriteLine('\n' + ">>>>>>>---->>>>>>");
                    Console.WriteLine($"Массив, отсортированный по убыванию значений в строках, строк:" + $"{N,2}" + ", столбцов :" + $"{M,2}" + ".");
                    BubbleSortbyRowTwoDimDesc(MyArray, false);     // Bubble Sort MyArray Descending
                    PrintRealArrayTwoDim(MyArray);
                    Console.WriteLine('\n' + ">>>>>>>---->>>>>>");
                    Console.WriteLine($"Массив, отсортированный по возрастанию значений в строках, строк:" + $"{N,2}" + ", столбцов :" + $"{M,2}" + ".");
                    BubbleSortbyRowTwoDimDesc(MyArray, true);     // Bubble Sort MyArray Ascending
                    PrintRealArrayTwoDim(MyArray);
                    break;

                }
                else
                {
                    ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
                    Console.ForegroundColor = colors[10];

                    Console.WriteLine(">>>>>>>---->>>>>>");
                    Console.WriteLine('\n' + $"АВАРИЙНОЕ ЗАВЕРШЕНИЕ ВВОДА ДАННЫХ (ESC)!");
                    Console.ResetColor();
                    PrintRealArrwithHeader("Распечатываем возвращаемый массив (Esc)", dArray, M);
                    break;


                }

            }

        }
    }

    End = DisplayReplyString('\n' + "Продолжить обработку (Y/N");
    nPos = 0;
    if (End == "n") break;
    if (End == "т") break;
    if (End == "Т") break;
    if (End == "N") break;

}



string[] stringArray = { "Х", "О", "Р", "О", "Ш", "Е", "Г", "О", " ", "Д", "Н", "Я", "!", "0" };

HappyNewYear(stringArray);  //   вывод на консоль приветственного сообщения.


