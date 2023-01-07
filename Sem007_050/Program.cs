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
// - CreateRealArrayTwoDim() - Метод инициализации массива вещественных чисет;
// - FillRealArrayTwoDim() - Метод заполнения массива вещественных чисел;
// - PrintRealArrayTwoDim() - Метод вывода содержимого массива на консоль с печатью заголовка (текстовой строки);
// - HappyNewYear() - Метод вывода на консоль сообщения (прогрессирующая текстовая строка, 
//                  с буквами разных цветов, подобранных по определенной  гамме)
//
string End = "Y";

while (End != "N")
{

    int N = DisplayReplyInt("Введите целое число - число строк массива");

    if (N < 1) Console.WriteLine("Число не может быть меньше 1");
    else
    {
        int M = DisplayReplyInt("Введите целое число - число столбцов массива");

        if (M < 1) Console.WriteLine("Число не может быть меньше 1");
        else
        {

            double[,] MyArray = CreateRealArrayTwoDim(N, M);   // инициализация массива
                                                               // далее будем вести обработку через одномерный массив, чтобы воспользоваться разработанным 
                                                               // ранее инструментарием для одномерных массивов

            int dArrayLength = N * M;

            double[] dArray = CreateRealArray(dArrayLength);

            //  double[] dArray1 = new double[dArrayLength];

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

                int nPos = 0;
                ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));

                while (nPos != -777)
                {
                    nPos = DisplayReplyIntSaveConsole('\n' + ('\n' + "Введите номер интересующей позиции в двумерном массиве (k-1)*col + current_col или -777 для выхода"));

                    if (nPos == -777) break;
                    if (nPos < 1 || nPos > dArray.Length)
                    {
                        Console.ForegroundColor = colors[12];
                        Console.WriteLine('\n' + $"Такого элемента в массиве нет: {nPos}");
                        Console.ResetColor();
                    }

                    else
                    {
                        // Console.Clear();
                        Console.WriteLine(">>>>>>>---->>>>>>");
                        Console.ForegroundColor = colors[14];
                        Console.WriteLine('\n' + $"Номер позиции: {nPos,1} , значение элемента: {dArray[nPos - 1].ToString("F3"),3} ");
                        Console.ResetColor();
                        Console.WriteLine('\n' + $"В массиве из {N,1} строк и {M,1} столбцов:" + '\n');
                        PrintRealArrayTwoDim(MyArray);
                    }
                }

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


            // Console.Clear();
            // Console.WriteLine(">>>>>>>---->>>>>>");
            // Console.WriteLine("Сформирован массив, строк: " + $"{N,2}" + ", столбцов :" + $"{M,2}" + "." + '\n');
            // PrintRealArrayTwoDim(MyArray);

        }
    }

    End = DisplayReplyString('\n' + "Продолжить обработку (Y/N");
    if (End == "n") break;
    if (End == "т") break;
    if (End == "Т") break;
    if (End == "N") break;

}



string[] stringArray = { "Х", "О", "Р", "О", "Ш", "Е", "Г", "О", " ", "Д", "Н", "Я", "!", "0" };

HappyNewYear(stringArray);  //   вывод на консоль рождественского поздравления.

