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

int nPosLeftToRight,  DigitInPos;


string End = "Y";

string WkDay = String.Empty;
string WkDayClass = String.Empty;

while (End != "N")
{
    N = DisplayReplyInt("Введите целое число: ");

    //  totaldigs = DigitsInNumber(N);

    //   if (N < 1 | N > 7)  // проверка на принадлежность ОДЗ (от 1 до 7)

    //   {
    //        Console.WriteLine("Ошибка при вводе числа - должно содержать только одну цифру.");

    //   }
    //   else   // если в числе больше одной цифры, то выдается сообщение об ошибке
    //   {

    nPosLeftToRight = 1;   // Берется первая слева цифра от числа

    DigitInPos = PosLeftToRight(N, nPosLeftToRight);

    if (WeekDaySpec(DigitInPos, wkday, wkDayClass))  Console.WriteLine(WkDay);

    WeekDaySpec(DigitInPos, wkday, wkDayClass);  Console.WriteLine(WkDay);

    else Console.WriteLine("Ошибка при вводе числа - должно содержать только одну цифру.");

    //   }

    Console.WriteLine("Продолжить обработку (Y/N");
    End = Console.ReadLine();
    if (End == "n") break;
    if (End == "т") break;
    if (End == "Т") break;
    if (End == "N") break;

}
