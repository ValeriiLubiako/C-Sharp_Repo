// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.6, 7 - выходной.
// 6 -> да
// 7 -> да
// 1 -> нет
//
//
using static MyLibrary;   //  ссылка на библиотеку
//
// - используем написанные ранее методы
// - DisplayReplyInt() - Метод ввода с терминала целого числа
// - PosLeftToRight() - Метод вывода заданной цифры из целого числа//  
// - WeekDayName() - вМетод возвращающий название дня недели или название - рабочий день или выходной...
//  

int lang;

int nPosLeftToRight, DigitInPos;

string WkDay = String.Empty;
string WkDayClass = String.Empty;


string End = "Y";

lang = 0;

while (End != "N")
{

    int N = DisplayReplyInt("Введите целое число");

    nPosLeftToRight = 1;   // Берется первая слева цифра от числа

    DigitInPos = PosLeftToRight(N, nPosLeftToRight);

    if (lang == 0)   //  при увеличении числа языков заменим на case

    {

        WkDay = WeekDayName(DigitInPos, true, 0);

        WkDayClass = WeekDayName(DigitInPos, false, 0);

    }

    else

    {
        WkDay = WeekDayName(DigitInPos, true, 1);  // Возвращает значения на английском - for future use

        WkDayClass = WeekDayName(DigitInPos, false, 1);   // Возвращает значения на английском - for future use

    }

    if (WkDay == "не определен") Console.WriteLine("Ошибка. Число выходит за допустимый диапазон значений (от 1 до 7)");

    else Console.WriteLine("Это " + $"{WkDay}" + "," + $"{WkDayClass}" + " день");

    //  if ( N < 0 | N > 9) Console.WriteLine ("Оценивали по самой левой цифре числа");
    if (N < 0 | N > 9) Console.WriteLine("Ошибка. Число выходит за допустимый диапазон значений (от 1 до 7)");

    Console.WriteLine();
    Console.WriteLine("Продолжить обработку (Y/N");
    End = Console.ReadLine();
    if (End == "n") break;
    if (End == "т") break;
    if (End == "Т") break;
    if (End == "N") break;

}
