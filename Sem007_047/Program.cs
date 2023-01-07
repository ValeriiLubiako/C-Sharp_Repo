// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
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

            FillRealArrayTwoDim(MyArray, -10000, 10001);    //  заполнение массива случайными числами

            Console.Clear();
            Console.WriteLine(">>>>>>>---->>>>>>");
            Console.WriteLine("Сформирован массив, строк: " + $"{N,2}" + ", столбцов :" + $"{M,2}" + "." + '\n');
            PrintRealArrayTwoDim(MyArray);

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
