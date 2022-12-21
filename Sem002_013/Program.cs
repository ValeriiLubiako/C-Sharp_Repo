// Задача 13: Напишите программу, которая выводит
// третью (слева) цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 ->  третьей цифры нет
// 32679 -> 6
//
using static MyLibrary;   //  ссылка на библиотеку
//
// используем написанный ранее метод 
// - DisplayReplyInt() - ввод целого числа с терминала
//  - PosLeftToRight() - возвращает числовое значение, соответствующее
//     цифре в указанном слева десятичном разряде
int N;

int nPosLeftToRight, DigitInPos;

string End = "Y";

while (End != "N")
{
    N = DisplayReplyInt("Введите целое число: ");

    nPosLeftToRight = DisplayReplyInt("Введите номер интересующей цифры в предыдущем числе: ");

    DigitInPos = PosLeftToRight(N, nPosLeftToRight);

    if (DigitInPos >= 0) Console.WriteLine("Значение интересующей цифры: " + $"{DigitInPos,3}");
    else Console.WriteLine("Цифры в разряде номер " + $"{nPosLeftToRight,3}" + " нет!!!");

    Console.WriteLine("Продолжить обработку (Y/N");

    End = Console.ReadLine();
    if (End == "n") break;
    if (End == "т") break;
    if (End == "Т") break;
    if (End == "N") break;

}