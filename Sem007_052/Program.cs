// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого
// элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет
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
            M = DisplayReplyIntSaveConsole("Введите целое число - число столбцов массива (выход -777)");

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

                    Console.Clear();
                    Console.WriteLine(">>>>>>>---->>>>>>");
                    Console.WriteLine("Сформирован массив, строк: " + $"{N,2}" + ", столбцов :" + $"{M,2}" + "." + '\n');
                    PrintRealArrayTwoDim(MyArray);

                    double[] averArr = CreateRealArray(M);
                    for (int i = 0; i < M; i++)
                    {
                        averArr[i] = 0;
                    }

                    for (int j = 0; j < M; j++)
                    {
                        for (int i = 0; i < N; i++) averArr[j] = averArr[j] + MyArray[i, j];
                        averArr[j] = averArr[j] / N;
                    }
                    Console.WriteLine();
                    PrintRealArrwithHeader('\n' + "Массив средних значений по столбцам:", averArr);
                    nPos = -777;
                    // ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));

                }

                else
                {
                    ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
                    Console.ForegroundColor = colors[10];

                    Console.WriteLine(">>>>>>>---->>>>>>");
                    Console.WriteLine('\n' + $"АВАРИЙНОЕ ЗАВЕРШЕНИЕ ВВОДА ДАННЫХ (ESC)!");
                    Console.ResetColor();
                    PrintRealArrwithHeader("Распечатываем возвращаемый массив (Esc)", dArray);
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

