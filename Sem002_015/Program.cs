// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным.6, 7 - выходной.
// 6 -> да
// 7 -> да
// 1 -> нет
//
//
using static MyLibrary;   //  ссылка на библиотеку
//
// используем написанный ранее метод 
// - DisplayReplyInt() - ввод целого числа с терминала
// - PosLeftToRight() - возвращает числовое значение, соответствующее
// -  DigitsInNumber() - возвращает количество цифр (десфтичных разрядов) в числе
//     цифре в указанном слева десятичном разряде
int N;

int lang;

int nPosLeftToRight, DigitInPos;

string WkDay = String.Empty;
string WkDayClass = String.Empty;


string End = "Y";

lang = 0;

while (End != "N")
{

    N = DisplayReplyInt("Введите целое число");

    nPosLeftToRight = 1;   // Берется первая слева цифра от числа

    DigitInPos = PosLeftToRight(N, nPosLeftToRight);

    if (lang == 0)   //  при увеличении числа языков заменим на case

    {

        WkDay = WeekDayName(DigitInPos, true, 0);

        WkDayClass = WeekDayName(DigitInPos, false, 0);

    }

    else

    {
        WkDay = WeekDayName(DigitInPos, true, 0);  // Возвращает значения на английском - for future use

        WkDayClass = WeekDayName(DigitInPos, false, 0);   // Возвращает значения на английском - for future use

    }

    if (WkDay == "не определен") Console.WriteLine("Ошибка. Число выходит за допустимый диапазон значений (от 1 до 7)");

    else Console.WriteLine("Это " + $"{WkDay}" + "," + $"{WkDayClass}" + " день");

    if ( N < 0 | N > 9) Console.WriteLine ("Оценивали по самой левой цифре числа");

    Console.WriteLine();
    Console.WriteLine("Продолжить обработку (Y/N");
    End = Console.ReadLine();
    if (End == "n") break;
    if (End == "т") break;
    if (End == "Т") break;
    if (End == "N") break;

}
