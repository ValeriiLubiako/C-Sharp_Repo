// Задача 38. Задайте массив вещественных чисел. Найдите разницу между
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

while (End != "N")
{

    int N = DisplayReplyInt("Введите целое число - число элементов массива");

    if (N < 1) Console.WriteLine("Число не может быть меньше 1");
    else
    {
        double[] MyArray = CreateRealArray(N);   // инициализация массива

        FillRealArray(MyArray, -100000, 100001);  //  заполнение массива случайными вещественными числами

        Console.WriteLine("Распечатываем массив");
        PrintRealArrayInLine(MyArray, 10);     //  вывод массива на консоль не более 10 элементов в строку
        //
        // В цикле простым перебором находим максимальное и минимальное значение элементов массива
        //
        // Double valmin, valmax;


        int i = 0;

        double valmin = MyArray[0];
        double valmax = MyArray[0];

        while (i < N)
        {
            double valArr = MyArray[i];

            if (valmin > valArr) valmin = valArr;
            if (valmax < valArr) valmax = valArr;
            i++;
        }


        Console.WriteLine(">>>>>>>---->>>>>>");
        // Console.WriteLine();
        Console.WriteLine('\n' + $"Минимальное значение: {valmin.ToString("F3"),3}" + '\n' + $"Максимальное значение: {valmax.ToString("F3"),3}");
        Console.WriteLine(("").PadRight(24, '-'));
        Console.WriteLine('\n' + $"Разница между макс и миним: {(valmax - valmin).ToString("F3"),3}");


        HappyNewYear();  //   вывод на консоль новогоднего поздравления.

    }
    End = DisplayReplyString("Продолжить обработку (Y/N");
    if (End == "n") break;
    if (End == "т") break;
    if (End == "Т") break;
    if (End == "N") break;
}